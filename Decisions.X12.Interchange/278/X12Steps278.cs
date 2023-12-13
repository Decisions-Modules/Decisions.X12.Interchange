using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using Decisions.X12.Interchange278X217Review;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;
using Interchange = Decisions.X12.Interchange278X217Review.Interchange;

namespace X12Interchange278;

[AutoRegisterMethodsOnClass(true, "Data", "X12", "278")]
public class X12Steps278
{
    public static Interchange Deserialize278X217Review(string ediString, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;

        using (FileStream fs = inputIsPath
                   ? new FileStream(ediString, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096,
                       FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None,
                       4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(ediString);
                }

                fs.Position = 0;
            }

            interchange = parser.Parse(fs);
        }

        // Create a temporary file with no sharing permissions that will be deleted when closed:
        using (FileStream fs = new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite,
                   FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            // Serialize the Interchange to file:
            interchange.Serialize(fs);
            // Prepare to read what we just wrote:
            fs.Position = 0;
            // Ignore ISA16 so the XmlSerializer doesn't throw an error when it sees an object instead of a string:
            var overrides = new XmlAttributeOverrides();
            overrides.Add(typeof(ISA), nameof(ISA.ISA16), new XmlAttributes { XmlIgnore = true });
            var serializer = new XmlSerializer(typeof(Interchange), overrides);

            using (XmlReader xmlReader = XmlReader.Create(fs,
                       new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
            {
                Interchange result = (Interchange)serializer.Deserialize(xmlReader,
                    new XmlDeserializationEvents
                    {
                        OnUnknownElement = HandleUnknownElement217Review
                    });

                if (result?.FunctionGroup?.Transaction?.ST?.ST01 != "278")
                    throw new InvalidOperationException("Incorrect document being used.  Please use 278");

                return result;
            }
        }
    }

    private static void HandleUnknownElement217Review(object obj, XmlElementEventArgs args)
    {
        if ((bool)!args?.Element?.Name?.Contains("Loop"))
            return;
        
        switch (args?.Element?.Attributes?["LoopId"]?.Value)
        {
            case "2000A": // UMOLevelLoop
            {
                Transaction217Review transaction = args?.ObjectBeingDeserialized as Transaction217Review;
                if(transaction == null)
                    throw new InvalidOperationException("Expected LoopId 2000A to be UMOLevelLoop inside Transaction");
                
                UMOLevelLoop217Review loop217Review = GetLoopValue217Review<UMOLevelLoop217Review>(args.Element);

                transaction.UMOLevelLoop217Review = loop217Review;
            }
            break;
            case "2010A": // UMONameLoop
            {
                UMOLevelLoop217Review umoLevelLoop217Review = args?.ObjectBeingDeserialized as UMOLevelLoop217Review;
                if (umoLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2010A inside UMOLevelLoop");

                UMONameLoop217Review loop217Review = GetLoopValue217Review<UMONameLoop217Review>(args.Element);

                umoLevelLoop217Review.UMONameLoop = loop217Review;
            }
            break;
            case "2000B": // RequesterLevelLoop
            {
                UMOLevelLoop217Review umoLevelLoop217Review = args?.ObjectBeingDeserialized as UMOLevelLoop217Review;
                if (umoLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2000B inside UMOLevelLoop");

                RequesterLevelLoop217Review loop217Review =
                    GetLoopValue217Review<RequesterLevelLoop217Review>(args.Element);

                umoLevelLoop217Review.RequesterLevelLoop217Review = loop217Review;
            }
            break;
            case "2010B": // RequesterNameLoop
            {
                RequesterLevelLoop217Review requesterLevelLoop217Review = args?.ObjectBeingDeserialized as RequesterLevelLoop217Review;
                if (requesterLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2010B inside RequesterLevelLoop");
                RequesterNameLoop217Review loop217Review =
                    GetLoopValue217Review<RequesterNameLoop217Review>(args.Element);

                requesterLevelLoop217Review.RequesterNameLoop = loop217Review;
            }
            break;
            case "2000C": // SubscriberLevelLoop
            {
                RequesterLevelLoop217Review requesterLevelLoop217Review = args?.ObjectBeingDeserialized as RequesterLevelLoop217Review;
                if (requesterLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2000C inside RequesterLevelLoop");
                
                SubscriberLevelLoop217Review loop217Review =
                    GetLoopValue217Review<SubscriberLevelLoop217Review>(args.Element);

                requesterLevelLoop217Review.SubscriberLevelLoop = loop217Review;
            }
            break;
            case "2010C": // SubscriberNameLoop
            {
                SubscriberLevelLoop217Review subscriberLevelLoop217Review = args?.ObjectBeingDeserialized as SubscriberLevelLoop217Review;

                if (subscriberLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2010C inside SubscriberLevelLoop");
                
                SubscriberNameLoop217Review loop217Review =
                    GetLoopValue217Review<SubscriberNameLoop217Review>(args.Element);

                subscriberLevelLoop217Review.SubscriberNameLoop = loop217Review;
            }
            break;
            case "2000D": // DependentLevelLoop
            {
                SubscriberLevelLoop217Review subscriberLevelLoop217Review = args?.ObjectBeingDeserialized as SubscriberLevelLoop217Review;

                if (subscriberLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2000D inside SubscriberLevelLoop");
                
                DependentLevelLoop217Review loop217Review =
                    GetLoopValue217Review<DependentLevelLoop217Review>(args.Element);

                subscriberLevelLoop217Review.DependentLevelLoop = loop217Review;
            }
            break;
            case "2010D": // DependentNameLoop
            {
                DependentLevelLoop217Review dependentLevelLoop217Review = args?.ObjectBeingDeserialized as DependentLevelLoop217Review;

                if (dependentLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2010D inside DependentLevelLoop");
                
                DependentNameLoop217Review loop217Review =
                    GetLoopValue217Review<DependentNameLoop217Review>(args.Element);

                dependentLevelLoop217Review.DependentNameLoop = loop217Review;
            }
            break;
            case "2000E": // PatientEventLevelLoop
            {
                SubscriberLevelLoop217Review subscriberLevelLoop217Review = args?.ObjectBeingDeserialized as SubscriberLevelLoop217Review;

                if (subscriberLevelLoop217Review == null)
                    throw new InvalidOperationException("Expected LoopId 2000E inside SubscriberLevelLoop");
                
                PatientEventLevelLoop217Review loop217Review =
                    GetLoopValue217Review<PatientEventLevelLoop217Review>(args.Element);

                subscriberLevelLoop217Review.PatientEventLevelLoop = loop217Review;
            }
            break;
        }
    }
      
      private static TLoop GetLoopValue217Review<TLoop>(XmlElement element)
      {
          using (StringReader stringReader = new StringReader(element.OuterXml))
          using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { IgnoreComments = true, CheckCharacters = false }))
          {
              XmlSerializer ser = new XmlSerializer(typeof(TLoop), new XmlRootAttribute(element.Name));
              TLoop loop = (TLoop)ser.Deserialize(xmlReader, new XmlDeserializationEvents
              {
                  OnUnknownElement = HandleUnknownElement217Review
              });

              return loop;
          }
      }
}