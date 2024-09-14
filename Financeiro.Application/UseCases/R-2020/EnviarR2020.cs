using Financeiro.Application.DependencyInjection;
using Financeiro.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.Domain.Despesas.DomainServices;
using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.Domain.EfdReinf.Interfaces;

namespace Financeiro.Application.UseCases.R_2020;
public class EnviarR2020(IEfdReinf efdReinf)
{
    private readonly RecuperarDespesasPorPeriodo _domainService = new(ContainerDependencyInjection.DespesasRepository);
    private readonly IEfdReinf _efdReinf = efdReinf;

    public async Task<EnviarR2020Resposta> ExecuteAsync(EnviarR2020Requisicao requisicao)
    {
        IEnumerable<Despesa> despesasFiltradas = await _domainService.ExecuteAsync(requisicao.Mes, requisicao.Ano);

        EnviarR2020Resposta efdReinfResposta = await _efdReinf.EnviarR2020Async(despesasFiltradas);

        return efdReinfResposta;
    }
}
