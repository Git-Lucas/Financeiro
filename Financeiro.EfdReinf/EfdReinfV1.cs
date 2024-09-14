using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.Domain.EfdReinf.Interfaces;
using System.Xml;

namespace Financeiro.EfdReinf;
public class EfdReinfV1 : IEfdReinf
{
    private readonly LeiauteEfdReinfV1 _leiauteEfdReinf = new();

    public async Task<EnviarR2020Resposta> EnviarR2020Async(IEnumerable<Despesa> despesasFiltradas)
    {
        return await Task.Run(() =>
        {
            Uri uri = new("https://reinf.receita.fazenda.gov.br/WsREINF/RecepcaoLoteReinf.svc");

            XmlDocument xmlRequisicao = _leiauteEfdReinf.GerarR2020Requisicao(despesasFiltradas);

            LogInformation(uri, xmlRequisicao);

            EnviarR2020Resposta respostaWebService = new(StatusResposta.Sucesso, new XmlDocument());
            return respostaWebService;
        });
    }

    private static void LogInformation(Uri uri, XmlDocument xmlRequisicao)
    {
        Console.WriteLine($"LOGGER APPLICATION: URL to request: {uri}");
        Console.WriteLine($"\r\nLOGGER APPLICATION: XML de requisição: {xmlRequisicao.ToIndentedString()}");
    }
}
