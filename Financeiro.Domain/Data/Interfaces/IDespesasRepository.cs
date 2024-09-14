using Financeiro.Domain.Despesas.Models;

namespace Financeiro.Domain.Data.Interfaces;
public interface IDespesasRepository
{
    Task<IEnumerable<Despesa>> RecuperarDespesasPorPeriodoVencimentoAsync(int mes, int ano);
}
