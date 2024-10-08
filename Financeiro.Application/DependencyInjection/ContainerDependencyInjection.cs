﻿using Financeiro.Domain.Data.Interfaces;
using Financeiro.Infrastructure.Data;

namespace Financeiro.Application.DependencyInjection;
public static class ContainerDependencyInjection
{
    public static IDespesasRepository DespesasRepository => new DespesasRepositoryMemory();
}
