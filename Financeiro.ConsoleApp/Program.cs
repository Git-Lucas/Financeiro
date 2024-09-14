using Financeiro.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.Application.UseCases.R_2020;
using Financeiro.Domain.EfdReinf.DTOs;
using Financeiro.EfdReinf;

EnviarR2020 enviarR2020 = new(new EfdReinfV1());

EnviarR2020Requisicao requisicao = new(02, 2023);
EnviarR2020Resposta respostaEfdReinf = await enviarR2020.ExecuteAsync(requisicao);

Console.WriteLine($"\r\nResultado da ação: {respostaEfdReinf.StatusResposta}");