using System.Text;
using Decisions.X12.Parsing;
using DecisionsFramework.Design.Flow;

namespace Decisions.X12.Interchange;

[AutoRegisterMethodsOnClass(true, "Data", "X12")]
public class X12GenericSteps
{
    public static string ConvertXmlToEdi(string xmlDocument, bool inputIsPath = false)
    {
        // X12 Xml string -> EDI string
        var parser = new X12Parser(true);
        string xmlString;

        using (FileStream fs = inputIsPath ? 
                   new FileStream(xmlDocument, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
        {
            if (!inputIsPath)
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8, 4096, true))
                {
                    writer.Write(xmlDocument);
                }

                fs.Position = 0;
            }

            using (StreamReader sr = new StreamReader(fs))
            {
                xmlString = sr.ReadToEnd();
            }

            xmlString = parser.TransformToX12(xmlString);
        }

        return xmlString;
    }
    
    public static string ConvertEdiToXml(string ediString, bool inputIsPath = false)
    {
        // EDI string -> X12 Xml string
        var parser = new X12Parser(true);
        Decisions.X12.Parsing.Model.Interchange interchange;
            
        using (FileStream fs = inputIsPath ?
                   new FileStream(ediString, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.None)
                   : new FileStream(Path.GetTempFileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose))
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

        return interchange.Serialize();
    }
}