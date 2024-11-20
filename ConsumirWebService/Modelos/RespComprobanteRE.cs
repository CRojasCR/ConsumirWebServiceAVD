namespace ConsumirWebService.Modelos
{
    public class RespComprobanteRE
    {
        public List<Result> result { get; set; } = [];
        public List<Estado> estado { get; set; } = [];
    }
    public class Result
    {
        public string ConsecutivoFactura { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        public string estadocomercial { get; set; } = string.Empty;
        public string estadofiscal { get; set; } = string.Empty;
        public string TipoDoc { get; set; } = string.Empty;
        public string CedulaEmisor { get; set; } = string.Empty;
        public string CedulaReceptor { get; set; } = string.Empty;
        public string NumeroOrden { get; set; } = string.Empty;
        public string Moneda { get; set; } = string.Empty;
        public string TipoCambio { get; set; } = string.Empty;
        public string IdPDV { get; set; } = string.Empty;
        public string NumeroGuia { get; set; } = string.Empty;
        public decimal Monto_Impuestos { get; set; } = decimal.Zero;
        public string Descuento { get; set; } = string.Empty;
        public decimal Monto_Total { get; set; } = decimal.Zero;
        public string documentoXML { get; set; } = string.Empty;
        public string Misc11 { get; set; } = string.Empty;
        public string Email_Receptor { get; set; } = string.Empty;
    }
    public class Estado
    {
        public string Resultado { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
    }
}
