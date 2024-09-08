﻿using Financeiro.Core.Domain.Despesas.Models;

namespace Financeiro.Core.Application.Data;
public interface IDespesasRepository
{
    Task<IEnumerable<Despesa>> RecuperarDespesasPorPeriodoVencimentoAsync(int mes, int ano);
}
