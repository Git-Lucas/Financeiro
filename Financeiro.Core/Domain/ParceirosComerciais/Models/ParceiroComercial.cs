namespace Financeiro.Core.Domain.ParceirosComerciais.Models;
public class ParceiroComercial
{
    public Guid Id => Guid.NewGuid();
    public string? Cnpj { get; private set; }
    public string? Cpf { get; private set; }
    public string Nome { get; private set; }

    public ParceiroComercial(string? cnpj, string? cpf, string nome)
    {
        Cnpj = cnpj;
        Cpf = cpf;
        Nome = nome;
    }

    public ParceiroComercial() { }
}
