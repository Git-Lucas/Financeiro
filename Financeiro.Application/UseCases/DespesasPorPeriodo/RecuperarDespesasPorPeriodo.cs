using Financeiro.Application.DependencyInjection;
using Financeiro.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.Interfaces.Data;

namespace Financeiro.Application.UseCases.DespesasPorPeriodo;
public class RecuperarDespesasPorPeriodo
{
    private readonly IDespesasRepository _despesasRepository = ContainerDependencyInjection.DespesasRepository;

    public async Task<IEnumerable<Despesa>> ExecuteAsync(RecuperarDespesasPorPeriodoRequisicao requisicao)
    {
        return await _despesasRepository.RecuperarDespesasPorPeriodoVencimentoAsync(requisicao.Mes, requisicao.Ano);
    }
}
