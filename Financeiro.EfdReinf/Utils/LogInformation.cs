using System.Xml;

namespace Financeiro.EfdReinf.Utils;
internal static class LogInformation
{
    internal static void EnvioLote(Uri uri, XmlDocument xmlRequisicao)
    {
        Console.WriteLine($"\r\nLOGGER APPLICATION ({nameof(EnvioLote)}): URL to request: {uri}");
        Console.WriteLine($"\r\nLOGGER APPLICATION ({nameof(EnvioLote)}): XML de requisição: {xmlRequisicao.ToIndentedString()}");
    }

    internal static void ConsultaLote(Uri uri)
    {
        Console.WriteLine($"\r\nLOGGER APPLICATION ({nameof(ConsultaLote)}): URL to request: {uri}");
    }
}
