using GeolocalizacionProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GeolocalizacionProject.Controllers
{
    [ApiController]
    [Route("api/v1/zonasegura")]
    public class ZonaSeguraController : ControllerBase
    {
        private readonly ZonaSegura zonaSegura = new ZonaSegura();


        private static readonly string[] ZonaSegura = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ZonaSeguraController> _logger;

        public ZonaSeguraController(ILogger<ZonaSeguraController> logger)
        {
            _logger = logger;
        }


        [HttpGet("obtenerZonas", Name = "ZonaSeguraCliente" )]
        public ZonaSegura[] ObtenerTodas()
        {

            ZonaSegura zona1 = new ZonaSegura
            {
                Id = 1,
                Nombre = "Zona Segura Trabajo",
                Descripcion = "Zona segura trabajo del cliente",
                Latitud = 40.7128,
                Longitud = -74.0060
            };


            ZonaSegura zona2 = new ZonaSegura
            {
                Id = 2,
                Nombre = "Zona Segura Casa",
                Descripcion = "Zona segura casa del cliente",
                Latitud = 40.7128,
                Longitud = -74.0060
            };

            ZonaSegura zona3 = new ZonaSegura
            {
                Id = 3,
                Nombre = "Zona Segura Piscina",
                Descripcion = "Zona segura piscina del cliente",
                Latitud = 40.7128,
                Longitud = -74.0060
            };

            ZonaSegura zona4 = new ZonaSegura
            {
                Id = 4,
                Nombre = "Zona Segura Juntas",
                Descripcion = "Zona segura juntas del pacifico",
                Latitud = 20.7128,
                Longitud = -14.0060
            };



            ZonaSegura[] zonaList = { zona1, zona2, zona3 };

            return zonaList;


        }
    }
}
