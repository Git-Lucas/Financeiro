using Financeiro.Application.UseCases.DespesasPorPeriodo;
using Financeiro.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.ConsoleApp;
using Financeiro.Domain.Despesas.Models;

RecuperarDespesasPorPeriodo recuperarDespesasPorPeriodo = new();

RecuperarDespesasPorPeriodoRequisicao requisicao = new(02, 2023);
IEnumerable<Despesa> despesasFiltradas = await recuperarDespesasPorPeriodo.ExecuteAsync(requisicao);

Console.WriteLine(Serializer.Serialize(despesasFiltradas));