using Financeiro.Domain.Despesas.Models;
using System.Xml;

namespace Financeiro.EfdReinf;

internal interface ILeiauteEfdReinf
{
    XmlDocument GerarR2020Requisicao(IEnumerable<Despesa> despesasFiltradas);
}