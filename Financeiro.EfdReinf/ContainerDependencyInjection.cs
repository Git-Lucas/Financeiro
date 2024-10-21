using Financeiro.Domain.EfdReinf.Interfaces;
using Financeiro.EfdReinf.WebServices;

namespace Financeiro.EfdReinf;
public static class ContainerDependencyInjection
{
    public static IEfdReinf GetEfdReinf(string? selectedEfdReinfVersion)
    {
        return selectedEfdReinfVersion switch
        {
            "1" => new EfdReinfV1(),
            "2" => new EfdReinfV2(),
            _ => throw new ArgumentOutOfRangeException(selectedEfdReinfVersion, $"Versão selecionada inválida: '{selectedEfdReinfVersion}'")
        };
    }
}
