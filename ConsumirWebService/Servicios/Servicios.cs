using ConsumirWebService.Clases;
using ConsumirWebService.Modelos;
using System.Text.Json;

namespace ConsumirWebService.Servicios
{
    public class Servicios : IServicio
    {
        #region Variables
        #endregion
        public Servicios()
        {
        }
        #region Metodos
        public async Task<RespAcuse> GetAcuse(Acuse acuse)
        {
            try
            {
                cClienteAVD clienteAVD = new();
                var cliente = clienteAVD.crearCliente();
                var respuesta = await cliente.getAcusesAsync(acuse.usuario, acuse.password, acuse.FechaInicial, acuse.FechaFinal, acuse.IdEmisor);
                string respJson = respuesta.Body.getAcusesResult;
                RespAcuse comprobateResp = JsonSerializer.Deserialize<RespAcuse>(respJson)!;
                return comprobateResp;
            }
            catch (Exception e)
            {
                throw new Exception("GetAcuse", e);
            }
        }

        public async Task<RespComprobantes> GetComprobantes(Comprobantes comprobantes)
        {
            try
            {
                cClienteAVD clienteAVD = new();
                var cliente = clienteAVD.crearCliente();
                var respuesta = await cliente.getComprobantesAsync(comprobantes.usuario, comprobantes.password, comprobantes.FechaInicial, comprobantes.FechaFinal,comprobantes.IdEmisor,comprobantes.Consecutivo);
                string respJson = respuesta.Body.getComprobantesResult;
                Console.WriteLine(respJson);
                RespComprobantes comprobateResp = JsonSerializer.Deserialize<RespComprobantes>(respJson)!;
                return comprobateResp;
            }
            catch (Exception e)
            {
                throw new Exception("GetComprobante", e);
            }
        }
        public async Task<RespComprobanteRE> GetComprobantesRE(ComprobantesRE comprobantesRE)
        {
            try
            {
                cClienteAVD clienteAVD = new();
                var cliente = clienteAVD.crearCliente();
                var respuesta = await cliente.getComprobantesREAsync(comprobantesRE.cUsuario, comprobantesRE.cContrasena, comprobantesRE.cFechaInicio,
                                                                    comprobantesRE.cFechaFinal, comprobantesRE.cIdReceptor, comprobantesRE.cIdEmisor, comprobantesRE.cClave);

                string respJson = respuesta.Body.getComprobantesREResult;
                RespComprobanteRE comprobateResp = JsonSerializer.Deserialize<RespComprobanteRE>(respJson)!;
                cTrasnformarDocumentoXML cTrasnformar = new();
                foreach (var item in comprobateResp.result)
                {
                    item.documentoXML = cTrasnformar.DocumentoXML(item.documentoXML);
                }
                return comprobateResp;
            }
            catch (Exception e)
            {
                throw new Exception("GetComprobantesRE", e);
            }
        }
        public async Task<string> PostGenerarEstadoComercial(GenerarEstadoComercial generarEstadoComercial)
        {
            try
            {
                cClienteAVD clienteAVD = new();
                var cliente = clienteAVD.crearCliente();
                var respuesta = await cliente.postGenerarEstadoComercialAsync(generarEstadoComercial.cUsuario, generarEstadoComercial.cContrasena,
                                                                             generarEstadoComercial.cClave, generarEstadoComercial.cEstado, generarEstadoComercial.cMotivo,
                                                                             generarEstadoComercial.cCorreoNotificar, generarEstadoComercial.cTipoIdReceptor, generarEstadoComercial.cIdReceptor);
                return respuesta.Body.postGenerarEstadoComercialResult.ToString();
            }
            catch (Exception e)
            {
                throw new Exception("GetAcuse", e);
            }
        }
        #endregion
    }
}
