using System.Xml;

namespace Financeiro.Domain.EfdReinf.DTOs;
public record EnviarR2020Resposta(StatusResposta StatusResposta, XmlDocument Xml)
{
}
