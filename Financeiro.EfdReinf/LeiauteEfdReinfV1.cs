using Financeiro.Domain.Despesas.Models;
using System.Xml;

namespace Financeiro.EfdReinf;
public class LeiauteEfdReinfV1 : ILeiauteEfdReinf
{
    public XmlDocument GerarR2020Requisicao(IEnumerable<Despesa> despesasFiltradas)
    {
        XmlDocument xmlDocument = new();

        XmlElement rootElement = xmlDocument.CreateElement("RequisicaoR2020");
        xmlDocument.AppendChild(rootElement);

        foreach (Despesa despesa in despesasFiltradas)
        {
            XmlElement despesaElement = xmlDocument.CreateElement("Despesa");

            xmlDocument = BuildParceiroComercial(xmlDocument, despesa);

            XmlElement dataEmissaoElement = xmlDocument.CreateElement("DataEmissao");
            dataEmissaoElement.InnerText = despesa.DataEmissao.ToString("yyyy-MM-dd");
            despesaElement.AppendChild(dataEmissaoElement);

            XmlElement dataVencimentoElement = xmlDocument.CreateElement("DataVencimento");
            dataVencimentoElement.InnerText = despesa.DataVencimento.ToString("yyyy-MM-dd");
            despesaElement.AppendChild(dataVencimentoElement);

            XmlElement valorTotalElement = xmlDocument.CreateElement("ValorTotal");
            valorTotalElement.InnerText = despesa.ValorTotal.ToString("F2");
            despesaElement.AppendChild(valorTotalElement);

            rootElement.AppendChild(despesaElement);
        }

        return xmlDocument;
    }

    private static XmlDocument BuildParceiroComercial(XmlDocument xmlDocument, Despesa despesa)
    {
        XmlElement parceiroComercialElement = xmlDocument.CreateElement("ParceiroComercial");

        XmlElement cnpjElement = xmlDocument.CreateElement("Cnpj");
        cnpjElement.InnerText = despesa.Beneficiario.Cnpj ?? "";
        parceiroComercialElement.AppendChild(cnpjElement);

        XmlElement cpfElement = xmlDocument.CreateElement("Cpf");
        cpfElement.InnerText = despesa.Beneficiario.Cpf ?? "";
        parceiroComercialElement.AppendChild(cpfElement);

        XmlElement nomeElement = xmlDocument.CreateElement("Nome");
        nomeElement.InnerText = despesa.Beneficiario.Nome ?? "";
        parceiroComercialElement.AppendChild(nomeElement);

        return xmlDocument;
    }
}
