using Financeiro.Domain.Data.Interfaces;
using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.Domain.EfdReinf.Interfaces;

namespace Financeiro.Application.UseCases;
public class EnviarR2020(IDespesasRepository despesasRepository, IEfdReinf efdReinf)
{
    private readonly IDespesasRepository _despesasRepository = despesasRepository;
    private readonly IEfdReinf _efdReinf = efdReinf;

    public async Task<EnviarR2020Resposta> ExecuteAsync(EnviarR2020Requisicao requisicao)
    {
        IEnumerable<Despesa> despesasFiltradas = await _despesasRepository.RecuperarDespesasPorPeriodoVencimentoAsync(requisicao.Mes, requisicao.Ano);

        EnviarR2020Resposta efdReinfResposta = await _efdReinf.EnviarR2020Async(despesasFiltradas);

        return efdReinfResposta;
    }
}

public record EnviarR2020Requisicao(int Mes, int Ano)
{
}
