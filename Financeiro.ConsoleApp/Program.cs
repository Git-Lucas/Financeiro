using Financeiro.ConsoleApp;
using Financeiro.Core.Application.Data;
using Financeiro.Core.Application.UseCases.DespesasPorPeriodo;
using Financeiro.Core.Application.UseCases.DespesasPorPeriodo.DTOs;
using Financeiro.Core.Domain.Despesas.Models;
using Financeiro.Infrastructure.Data;

IDespesasRepository despesasRepository = new DespesasRepositoryMemory();
RecuperarDespesasPorPeriodo recuperarDespesasPorPeriodo = new(despesasRepository);

RecuperarDespesasPorPeriodoRequisicao requisicao = new(02, 2023);
IEnumerable<Despesa> despesasFiltradas = await recuperarDespesasPorPeriodo.ExecuteAsync(requisicao);

Console.WriteLine(Serializer.Serialize(despesasFiltradas));