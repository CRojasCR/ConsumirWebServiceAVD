namespace ConsumirWebService.Modelos
{
    public class RespAcuse
    {
        public List<Result> result { get; set; } = [];
        public List<Estado> estado { get; set; } = [];
    public class Result
    {
        public string Fecha_insercion { get; set; } = string.Empty;
        public string Consecutivo { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
    public class Estado
    {
        public string Resultado { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
    }
}
}
