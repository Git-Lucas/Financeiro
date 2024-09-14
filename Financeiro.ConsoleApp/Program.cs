using Financeiro.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.Application.UseCases.R_2020;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.Domain.EfdReinf.Interfaces;
using Financeiro.EfdReinf.WebServices;

Console.WriteLine("O EFD Reinf possui 2 versões disponíveis para o envio dos XMLs. Selecione: ");
Console.WriteLine("1 - Versão 1 (versão que será descontinuada em 10 dias);");
Console.WriteLine($"2 - Versão 2 (versão obrigatória a partir de {DateTime.Now.AddDays(10).ToShortDateString()});");

string? selectedEfdReinfVersion = Console.ReadLine();
IEfdReinf efdReinf = GetEfdReinf(selectedEfdReinfVersion);

EnviarR2020 enviarR2020 = new(efdReinf);

EnviarR2020Requisicao requisicao = new(02, 2023);
EnviarR2020Resposta respostaEfdReinf = await enviarR2020.ExecuteAsync(requisicao);

Console.WriteLine($"\r\nResultado da ação: {respostaEfdReinf.StatusResposta}");

static IEfdReinf GetEfdReinf(string? selectedEfdReinfVersion)
{
    return selectedEfdReinfVersion switch
    {
        "1" => new EfdReinfV1(),
        "2" => new EfdReinfV2(),
        _ => throw new ArgumentOutOfRangeException(selectedEfdReinfVersion, $"Versão selecionada inválida: '{selectedEfdReinfVersion}'")
    };
}