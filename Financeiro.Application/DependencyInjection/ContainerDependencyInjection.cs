using Financeiro.Domain.Interfaces.Data;
using Financeiro.Infrastructure.Data;

namespace Financeiro.Application.DependencyInjection;
public static class ContainerDependencyInjection
{
    public static IDespesasRepository DespesasRepository => new DespesasRepositoryMemory();
}
