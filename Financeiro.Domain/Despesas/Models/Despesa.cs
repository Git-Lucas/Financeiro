using Financeiro.Domain.ParceirosComerciais.Models;
using Financeiro.Domain.Util;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Domain.Despesas.Models;
public class Despesa
{
    public Guid Id => Guid.NewGuid();
    public ParceiroComercial Beneficiario { get; private set; }
    public DateTime DataEmissao { get; private set; }
    public DateTime DataVencimento { get; private set; }

    [Range(0, double.MaxValue, ErrorMessage = "O {0} deve ser maior que {1}.")]
    public decimal ValorTotal { get; private set; }

    public Despesa(ParceiroComercial beneficiario, DateTime dataEmissao, DateTime dataVencimento, decimal valorTotal)
    {
        Beneficiario = beneficiario;
        DataEmissao = dataEmissao;
        DataVencimento = dataVencimento;
        ValorTotal = valorTotal;

        ModelsValidator.Execute(this);
    }

    public Despesa()
    {
        ModelsValidator.Execute(this);
    }
}
