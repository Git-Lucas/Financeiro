using Financeiro.Domain.Despesas.Models;
using System.Xml;

namespace Financeiro.EfdReinf.Leiautes;

internal interface ILeiauteEfdReinf
{
    XmlDocument GerarR2020Requisicao(IEnumerable<Despesa> despesasFiltradas);
}