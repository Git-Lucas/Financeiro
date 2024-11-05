using System.Xml;

namespace Financeiro.EfdReinf.Utils;
internal static class LogInformation
{
    public static void EnvioLote(Uri uri, XmlDocument xmlRequisicao)
    {
        Console.WriteLine($"\r\nLOGGER APPLICATION ({nameof(EnvioLote)}): URL to request: {uri}");
        Console.WriteLine($"\r\nLOGGER APPLICATION ({nameof(EnvioLote)}): XML de requisição: {xmlRequisicao.ToIndentedString()}");
    }

    public static void ConsultaLote(Uri uri)
    {
        Console.WriteLine($"\r\nLOGGER APPLICATION ({nameof(ConsultaLote)}): URL to request: {uri}");
    }
}
