using DecisionsFramework.Design.Flow;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace X12Interchange834
{
    [AutoRegisterMethodsOnClass(true, "Data", "X12")]
    public static class X12Steps
    {
        public static Interchange DeserializeFrom834(string Document834, bool InputIsPath = false)
        {
            // 834 -> lib Interchange -> xml -> Decisions Interchange
            var parser = new Decisions.X12.Parsing.X12Parser(true);
            Decisions.X12.Parsing.Model.Interchange oopFactoryInterchange;

            // Stream from the given path, or write the document to a temp file to avoid allocation of huge byte array in MemoryStream:
            using (FileStream fs834 = InputIsPath ?
                new FileStream(Document834, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
            {
                if (!InputIsPath)
                {
                    using (StreamWriter writer = new StreamWriter(fs834, Encoding.UTF8, 4096, true))
                    {
                        writer.Write(Document834);
                    }
                    fs834.Position = 0;
                }
                oopFactoryInterchange = parser.Parse(fs834);
            }
            // Create a temporary file with no sharing permissions that will be deleted when closed:
            using (FileStream fs = new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
            {
                // Serialize the Interchange to file:
                oopFactoryInterchange.Serialize(fs);
                // Prepare to read what we just wrote:
                fs.Position = 0;
                // Ignore ISA16 so the XmlSerializer doesn't throw an error when it sees an object instead of a string:
                var overrides = new XmlAttributeOverrides();
                overrides.Add(typeof(ISA834), nameof(ISA834.ISA16), new XmlAttributes { XmlIgnore = true });
                var serializer = new XmlSerializer(typeof(Interchange), overrides);

                using (XmlReader xmlReader = XmlReader.Create(fs, new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
                {
                    Interchange result = (Interchange)serializer.Deserialize(xmlReader,
                        new XmlDeserializationEvents
                        {
                            OnUnknownElement = HandleUnknownElement
                        });

                    // Now that we're done adding to the List<T>, assign to MemberLevelDetailLoop:
                    if (result?.FunctionGroup?.Transaction?.memberLevelDetailLoopForDeserialize != null)
                    {
                        result.FunctionGroup.Transaction.MemberLevelDetailLoop = result.FunctionGroup.Transaction.memberLevelDetailLoopForDeserialize.ToArray();
                        result.FunctionGroup.Transaction.memberLevelDetailLoopForDeserialize = null;
                    }

                    return result;
                }
            }
        }

        // Check loop type by ID and deserialize correctly:
        private static void HandleUnknownElement(object obj, XmlElementEventArgs args)
        {
            if (args?.Element?.Name != "Loop")
                return;

            switch (args?.Element?.Attributes?["LoopId"]?.Value)
            {
                case "1000A": // SponsorNameLoop
                    {
                        Transaction transaction = args?.ObjectBeingDeserialized as Transaction;
                        if (transaction == null)
                            throw new InvalidOperationException("Expected LoopId 1000A to be SponsorNameLoop inside Transaction");

                        transaction.SponsorNameLoop = GetLoopValue<SponsorNameLoop>(args.Element);
                    }
                    break;
                case "2000": // MemberLevelDetailLoop
                    {
                        Transaction transaction = args?.ObjectBeingDeserialized as Transaction;
                        if (transaction == null)
                            throw new InvalidOperationException("Expected LoopId 2000 to be MemberLevelDetailLoop inside Transaction");

                        MemberLevelDetailLoop newLoop = GetLoopValue<MemberLevelDetailLoop>(args.Element);

                        if (transaction.memberLevelDetailLoopForDeserialize == null)
                            transaction.memberLevelDetailLoopForDeserialize = new List<MemberLevelDetailLoop>();

                        // This list will be assigned to the array property at the end:
                        transaction.memberLevelDetailLoopForDeserialize.Add(newLoop);
                    }
                    break;
                case "2100A": // MemberNameLoop
                    {
                        MemberLevelDetailLoop detailLoop = args?.ObjectBeingDeserialized as MemberLevelDetailLoop;
                        if (detailLoop == null)
                            throw new InvalidOperationException("Expected LoopId 2100A to be MemberNameLoop inside MemberLevelDetailLoop");

                        detailLoop.MemberNameLoop = GetLoopValue<MemberNameLoop>(args.Element);
                    }
                    break;
                case "2300": // HealthCoverageLoop
                    {
                        MemberLevelDetailLoop detailLoop = args?.ObjectBeingDeserialized as MemberLevelDetailLoop;
                        if (detailLoop == null)
                            throw new InvalidOperationException("Expected LoopId 2300 to be HealthCoverageLoop inside MemberLevelDetailLoop");

                        detailLoop.HealthCoverageLoop = GetLoopValue<HealthCoverageLoop>(args.Element);
                    }
                    break;
            }
        }

        private static TLoop GetLoopValue<TLoop>(XmlElement element)
        {
            using (StringReader stringReader = new StringReader(element.OuterXml))
            using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
            {
                XmlSerializer ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
                TLoop loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
                {
                    OnUnknownElement = HandleUnknownElement
                });

                return loop;
            }
        }

        public static string SerializeTo834(Interchange Interchange)
        {
            // Decisions Interchange -> xml -> 834
            string xml;
            using(var ms = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(Interchange));
                serializer.Serialize(ms, Interchange);
                xml = Encoding.UTF8.GetString(ms.ToArray());
            }

            xml = ApplyXsltTransform(xml, xsltForSerialize);

            var parser = new Decisions.X12.Parsing.X12Parser(true);
            string result = parser.TransformToX12(xml);
            return result;
        }

        static string ApplyXsltTransform(string xml, string xslt)
        {
            using (var xmlStringReader = new StringReader(xml))
            using (var xsltStringReader = new StringReader(xslt))
            {
                var xslTransform = new XslCompiledTransform();
                try
                {
                    using (XmlReader xmlReader = XmlReader.Create(xsltStringReader))
                    {
                        xslTransform.Load(xmlReader);
                    }
                }
                catch (XsltException)
                {
                    throw new Exception("XSLT stylesheet format is invalid");
                }

                try
                {
                    XmlWriterSettings settings = new XmlWriterSettings
                    {
                        OmitXmlDeclaration = true
                    };

                    using (XmlReader xmlReader = XmlReader.Create(xmlStringReader))
                    using (var stringWriter = new StringWriter())
                    using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                    {
                        xslTransform.Transform(xmlReader, xmlWriter);
                        return stringWriter.ToString();
                    }
                }
                catch (XsltException)
                {
                    throw new Exception("XSLT transform could not be applied");
                }
                catch (XmlException)
                {
                    throw new Exception("XML doc contains errors");
                }
                catch (InvalidOperationException ex)
                {
                    if (ex.Message.StartsWith("Token Text in state Start would result in an invalid XML document"))
                        throw new Exception("Output is not valid XML");
                    else
                        throw;
                }
            }
        }

        // Might consider using "<xsl:strip-space elements=""*""/>" here, but it might cause the output to have no line breaks?
        const string xsltForSerialize = @"<xsl:stylesheet version=""1.0""
 xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"">

 <xsl:output omit-xml-declaration=""yes"" encoding=""utf-8""/>
    <xsl:template match=""node()|@*"">
      <xsl:copy>
         <xsl:apply-templates select=""node()|@*""/>
      </xsl:copy>
    </xsl:template>

    <xsl:template match=""ISA16"">
        <ISA16>
          <ISA1601 />
          <ISA1602 />
		</ISA16>
    </xsl:template>
    <xsl:template match=""SponsorNameLoop"">
        <Loop>
            <xsl:apply-templates select=""@* | node()""/>
        </Loop>
    </xsl:template>
    <xsl:template match=""MemberLevelDetailLoop"">
        <Loop>
            <xsl:apply-templates select=""@* | node()""/>
        </Loop>
    </xsl:template>
    <xsl:template match=""MemberNameLoop"">
        <Loop>
            <xsl:apply-templates select=""@* | node()""/>
        </Loop>
    </xsl:template>
    <xsl:template match=""HealthCoverageLoop"">
        <Loop>
            <xsl:apply-templates select=""@* | node()""/>
        </Loop>
    </xsl:template>
</xsl:stylesheet>";
    }
}
