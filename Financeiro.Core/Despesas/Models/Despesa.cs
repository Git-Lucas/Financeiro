using Financeiro.Domain.ParceirosComerciais.Models;

namespace Financeiro.Domain.Despesas.Models;
public class Despesa
{
    public Guid Id => Guid.NewGuid();
    public ParceiroComercial Beneficiario { get; private set; }
    public DateTime DataEmissao { get; private set; }
    public DateTime DataVencimento { get; private set; }
    public decimal ValorTotal { get; private set; }

    public Despesa(ParceiroComercial beneficiario, DateTime dataEmissao, DateTime dataVencimento, decimal valorTotal)
    {
        Beneficiario = beneficiario;
        DataEmissao = dataEmissao;
        DataVencimento = dataVencimento;
        ValorTotal = valorTotal;
    }

    public Despesa() { }
}
