using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.EfdReinf.DTOs;

namespace Financeiro.Domain.EfdReinf.Interfaces;
public interface IEfdReinf
{
    Task<EnviarR2020Resposta> EnviarR2020Async(IEnumerable<Despesa> despesasFiltradas);
}
