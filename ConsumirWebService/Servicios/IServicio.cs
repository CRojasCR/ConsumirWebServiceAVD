using ConsumirWebService.Modelos;

namespace ConsumirWebService.Servicios
{
    public interface IServicio
    {
        Task<RespComprobantes> GetComprobantes(Comprobantes comprobantes);
        Task<RespAcuse> GetAcuse(Acuse acuse);
        Task<RespComprobanteRE> GetComprobantesRE(ComprobantesRE comprobantesRE);
        Task<string> PostGenerarEstadoComercial(GenerarEstadoComercial generarEstadoComercial);
    }
}
