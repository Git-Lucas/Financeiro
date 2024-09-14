using Financeiro.Domain.Data.Interfaces;
using Financeiro.Domain.Despesas.Models;

namespace Financeiro.Domain.Despesas.DomainServices;
public class RecuperarDespesasPorPeriodo(IDespesasRepository despesasRepository)
{
    private readonly IDespesasRepository _despesasRepository = despesasRepository;

    public async Task<IEnumerable<Despesa>> ExecuteAsync(int mes, int ano)
    {
        return await _despesasRepository.RecuperarDespesasPorPeriodoVencimentoAsync(mes, ano);
    }
}
