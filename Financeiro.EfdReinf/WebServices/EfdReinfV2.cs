using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.Domain.EfdReinf.Interfaces;
using Financeiro.EfdReinf.Leiautes;
using Financeiro.EfdReinf.Utils;
using System.Xml;

namespace Financeiro.EfdReinf.WebServices;
internal class EfdReinfV2 : IEfdReinf
{
    private readonly LeiauteEfdReinfV1 _leiauteEfdReinf = new();

    public async Task<EnviarR2020Resposta> EnviarR2020Async(IEnumerable<Despesa> despesasFiltradas)
    {
        return await Task.Run(() =>
        {
            string numeroProtocolo = EnviarLote(despesasFiltradas);

            ConsultarLote(numeroProtocolo);

            EnviarR2020Resposta respostaWebService = new(StatusResposta.Sucesso, new XmlDocument());
            return respostaWebService;
        });
    }

    private string EnviarLote(IEnumerable<Despesa> despesasFiltradas)
    {
        Uri uri = new("https://reinf.receita.economia.gov.br/recepcao/lotes");

        XmlDocument xmlRequisicao = _leiauteEfdReinf.GerarR2020Requisicao(despesasFiltradas);

        LogInformation.EnvioLote(uri, xmlRequisicao);

        string numeroProtocoloMock = "1.202003.123";
        return numeroProtocoloMock;
    }

    private static void ConsultarLote(string numeroProtocolo)
    {
        Uri uri = new($"https://reinf.receita.economia.gov.br/consulta/lotes/{numeroProtocolo}");

        LogInformation.ConsultaLote(uri);
    }
}
