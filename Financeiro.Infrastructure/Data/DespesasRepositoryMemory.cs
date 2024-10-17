using Financeiro.Domain.Data.Interfaces;
using Financeiro.Domain.Despesas.Models;
using Financeiro.Domain.ParceirosComerciais.Models;

namespace Financeiro.Infrastructure.Data;
public class DespesasRepositoryMemory : IDespesasRepository
{
    private readonly IEnumerable<Despesa> _despesas =
    [
        new(new ParceiroComercial("12345678000195", null, "Comercial Silva Ltda"),
            new DateTime(2023, 1, 10, 14, 30, 45, DateTimeKind.Utc),
            new DateTime(2023, 2, 10, 9, 15, 30, DateTimeKind.Utc),
            1500.00m),
        new(new ParceiroComercial(null, "12345678900", "João Pereira"),
            new DateTime(2023, 1, 12, 8, 45, 12, DateTimeKind.Utc),
            new DateTime(2023, 2, 12, 13, 30, 5, DateTimeKind.Utc),
            800.00m),
        new(new ParceiroComercial("98765432000199", null, "Tecno Service LTDA"),
            new DateTime(2023, 1, 15, 17, 10, 55, DateTimeKind.Utc),
            new DateTime(2023, 2, 15, 10, 50, 25, DateTimeKind.Utc),
            3200.50m),
        new(new ParceiroComercial(null, "98765432100", "Maria Souza"),
            new DateTime(2023, 1, 20, 12, 40, 20, DateTimeKind.Utc),
            new DateTime(2023, 2, 20, 15, 25, 15, DateTimeKind.Utc),
            1250.75m),
        new(new ParceiroComercial("11223344000188", null, "Alimentos Brasil EIRELI"),
            new DateTime(2023, 1, 22, 7, 25, 35, DateTimeKind.Utc),
            new DateTime(2023, 2, 22, 18, 35, 45, DateTimeKind.Utc),
            2300.00m),
        new(new ParceiroComercial(null, "22334455600", "Carlos Oliveira"),
            new DateTime(2023, 1, 25, 9, 15, 10, DateTimeKind.Utc),
            new DateTime(2023, 2, 25, 11, 55, 20, DateTimeKind.Utc),
            950.00m),
        new(new ParceiroComercial("55667788000177", null, "Construtora Alfa Ltda"),
            new DateTime(2023, 1, 28, 19, 30, 0, DateTimeKind.Utc),
            new DateTime(2023, 2, 28, 13, 45, 50, DateTimeKind.Utc),
            1875.60m),
        new(new ParceiroComercial(null, "66554433211", "Ana Paula Martins"),
            new DateTime(2023, 1, 30, 22, 20, 5, DateTimeKind.Utc),
            new DateTime(2023, 2, 28, 9, 35, 15, DateTimeKind.Utc),
            1025.30m),
        new(new ParceiroComercial("77889900000166", null, "Logística Silva e Cia"),
            new DateTime(2023, 2, 1, 16, 55, 40, DateTimeKind.Utc),
            new DateTime(2023, 3, 1, 20, 40, 25, DateTimeKind.Utc),
            2900.00m),
        new(new ParceiroComercial(null, "11223344550", "Pedro Henrique Santos"),
            new DateTime(2023, 2, 5, 11, 5, 15, DateTimeKind.Utc),
            new DateTime(2023, 3, 5, 7, 25, 45, DateTimeKind.Utc),
            1750.80m)
    ];


    public async Task<IEnumerable<Despesa>> RecuperarDespesasPorPeriodoVencimentoAsync(int mes, int ano)
    {
        return _despesas.Where(x => x.DataVencimento.Month == mes
                                             && x.DataVencimento.Year == ano);
    }
}
