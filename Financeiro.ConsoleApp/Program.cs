using Financeiro.Application.UseCases;
using Financeiro.Domain.Data.Interfaces;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.Domain.EfdReinf.Interfaces;

Console.WriteLine("O EFD Reinf possui 2 versões disponíveis para o envio dos XMLs. Selecione: ");
Console.WriteLine("1 - Versão 1 (versão que será descontinuada em 10 dias);");
Console.WriteLine($"2 - Versão 2 (versão obrigatória a partir de {DateTime.Now.AddDays(10).ToShortDateString()});");

IDespesasRepository despesasRepository = Financeiro.Infrastructure.ContainerDependencyInjection.DespesasRepository;
string? selectedEfdReinfVersion = Console.ReadLine();
IEfdReinf efdReinf = Financeiro.EfdReinf.ContainerDependencyInjection.GetEfdReinf(selectedEfdReinfVersion);
EnviarR2020 enviarR2020 = new(despesasRepository, efdReinf);

EnviarR2020Requisicao requisicao = new(02, 2023);
EnviarR2020Resposta respostaEfdReinf = await enviarR2020.ExecuteAsync(requisicao);

Console.WriteLine($"\r\nResultado da ação: {respostaEfdReinf.StatusResposta}");