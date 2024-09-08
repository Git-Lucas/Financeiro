using Financeiro.Domain.Despesas.Models;

namespace Financeiro.Domain.Interfaces.Data;
public interface IDespesasRepository
{
    Task<IEnumerable<Despesa>> RecuperarDespesasPorPeriodoVencimentoAsync(int mes, int ano);
}
