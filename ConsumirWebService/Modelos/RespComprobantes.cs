using System.Text.Json.Serialization;

namespace ConsumirWebService.Modelos
{
    public class RespComprobantes
    {
        [JsonPropertyName("result")]
        public List<Result> result { get; set; } = new List<Result>();

        [JsonPropertyName("estado")]
        public List<Estado> estado { get; set; } = new List<Estado>();

        public class Result
        {
            [JsonPropertyName("fecha")]
            public string Fecha { get; set; } = string.Empty;

            [JsonPropertyName("folio")]
            public string Folio { get; set; } = string.Empty;

            [JsonPropertyName("Misc03")]
            public string Misc03 { get; set; } = string.Empty;

            [JsonPropertyName("Misc30")]
            public string Misc30 { get; set; } = string.Empty;

            [JsonPropertyName("Numero_Tienda")]
            public string Numero_Tienda { get; set; } = string.Empty;

            [JsonPropertyName("Misc40")]
            public string Misc40 { get; set; } = string.Empty;

            [JsonPropertyName("Misc01")]
            public string Misc01 { get; set; } = string.Empty;

            [JsonPropertyName("Tipo_Especial_de_Servicio")]
            public string Tipo_Especial_de_Servicio { get; set; } = string.Empty;

            [JsonPropertyName("Monto_SubTotal")]
            public decimal Monto_SubTotal { get; set; } = decimal.Zero;

            [JsonPropertyName("Monto_TotalSerExen")]
            public decimal Monto_TotalSerExen { get; set; } = decimal.Zero;

            [JsonPropertyName("Monto_Total_Descuentos")]
            public decimal Monto_Total_Descuentos { get; set; } = decimal.Zero;
        }

        public class Estado
        {
            [JsonPropertyName("resultado")]
            public string Resultado { get; set; } = string.Empty;

            [JsonPropertyName("mensaje")]
            public string Mensaje { get; set; } = string.Empty;
        }
    }
}
