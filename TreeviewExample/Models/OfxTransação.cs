using System;
using System.Xml.Serialization;

namespace TreeviewExample.Models
{
    public record OfxTransação(
        [XmlElement("TRNTYPE")] string TipoDeTransação,
        [XmlElement("DTPOSTED")] DateTime DataDaTransação,
        [XmlElement("TRNAMT")] decimal Valor,
        [XmlElement("FITID")] string IDFatura,
        [XmlElement("CHECKNUM")] string NumeroDoPagamento,
        [XmlElement("REFNUM")] string Referencia,
        [XmlElement("MEMO")] string Historico
        );
}