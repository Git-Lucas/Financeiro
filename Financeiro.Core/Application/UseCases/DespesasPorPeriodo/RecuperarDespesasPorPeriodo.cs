using Financeiro.Core.Application.Data;
using Financeiro.Core.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.Core.Domain.Despesas.Models;

namespace Financeiro.Core.Application.UseCases.DespesasPorPeriodo;
public class RecuperarDespesasPorPeriodo(IDespesasRepository despesasRepository)
{
    private readonly IDespesasRepository _despesasRepository = despesasRepository;

    public async Task<IEnumerable<Despesa>> ExecuteAsync(RecuperarDespesasPorPeriodoRequisicao requisicao)
    {
        return await _despesasRepository.RecuperarDespesasPorPeriodoVencimentoAsync(requisicao.Mes, requisicao.Ano);
    }
}
