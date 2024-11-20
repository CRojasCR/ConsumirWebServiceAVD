using ConsumirWebService.Modelos;
using ConsumirWebService.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ConsumirWebService.Controllers
{
    [Route("api/v1.0")]
    [ApiController]
    public class wsAVDController : ControllerBase
    {
        private readonly IServicio servicio;

        public wsAVDController(IServicio servicio)
        {
            this.servicio = servicio;
        }
        [HttpGet("Comprobantes")]
        public async Task<ActionResult<Comprobantes>> getComprobantes([FromQuery] Comprobantes comprobantes)
        {
            try
            {
                if (string.IsNullOrEmpty(comprobantes.usuario) || string.IsNullOrEmpty(comprobantes.password))
                {
                    return BadRequest("Todos los parámetros son obligatorios.");
                }
                var resultado = await servicio.GetComprobantes(comprobantes);
                if (resultado.result.Count <= 0)
                {
                    return NotFound("Comprobantes no encontrados.");
                }
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servicio: {ex.Message}");
            }
        }
        [HttpGet("Acuses")]
        public async Task<ActionResult<Acuse>> getAcuses([FromQuery] Acuse acuse)
        {
            try
            {
                if (string.IsNullOrEmpty(acuse.usuario) || string.IsNullOrEmpty(acuse.password)
                    || string.IsNullOrEmpty(acuse.FechaInicial) || string.IsNullOrEmpty(acuse.FechaFinal))
                {
                    return BadRequest("Todos los parámetros son obligatorios.");
                }
                var resultado = await servicio.GetAcuse(acuse);
                if (resultado.result.Count <= 0)
                {
                    return NotFound("Acuses no encontrados.");
                }
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servicio: {ex.Message}");
            }
        }
        [HttpGet("ComprobantesRE")]
        public async Task<ActionResult<ComprobantesRE>> getComprobantesRE([FromQuery] ComprobantesRE comprobantesRE)
        {
            try
            {
                if (string.IsNullOrEmpty(comprobantesRE.cUsuario) || string.IsNullOrEmpty(comprobantesRE.cContrasena)
                    || string.IsNullOrEmpty(comprobantesRE.cFechaInicio) || string.IsNullOrEmpty(comprobantesRE.cFechaFinal))
                {
                    return BadRequest("Todos los parámetros son obligatorios.");
                }
                var resultado = await servicio.GetComprobantesRE(comprobantesRE);
                if (resultado.result.Count<=0)
                {
                    return NotFound("Acuses no encontrados.");
                }
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servicio: {ex.Message}");
            }
        }
        [HttpPost("GenerarEstadoComercial")]
        public async Task<ActionResult<string>> postGenerarEstadoComercial([FromQuery] GenerarEstadoComercial generarEstadoComercial)
        {
            try
            {
                if (string.IsNullOrEmpty(generarEstadoComercial.cUsuario) || string.IsNullOrEmpty(generarEstadoComercial.cContrasena)
                    || string.IsNullOrEmpty(generarEstadoComercial.cClave) || string.IsNullOrEmpty(generarEstadoComercial.cEstado)
                    || string.IsNullOrEmpty(generarEstadoComercial.cMotivo) || string.IsNullOrEmpty(generarEstadoComercial.cCorreoNotificar)
                    || string.IsNullOrEmpty(generarEstadoComercial.cTipoIdReceptor) || string.IsNullOrEmpty(generarEstadoComercial.cIdReceptor))
                {
                    return BadRequest("Todos los parámetros son obligatorios.");
                }
                var resultado = await servicio.PostGenerarEstadoComercial(generarEstadoComercial);
                if (string.IsNullOrEmpty(resultado))
                {
                    return StatusCode(500,"Problema al generar el estado comercial.");
                }
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en el servicio: {ex.Message}");
            }
        }

    }
}
