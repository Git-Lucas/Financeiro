using System.Xml;

namespace Financeiro.EfdReinf.Utils;
internal static class XmlExtensions
{
    public static string ToIndentedString(this XmlDocument xmlDocument)
    {
        using StringWriter stringWriter = new();

        XmlWriterSettings settings = new()
        {
            Indent = true,
            IndentChars = "  ",
            NewLineChars = "\r\n",
            NewLineHandling = NewLineHandling.Replace
        };

        using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
        {
            xmlDocument.WriteTo(xmlWriter);
        }

        return stringWriter.ToString();
    }
}
