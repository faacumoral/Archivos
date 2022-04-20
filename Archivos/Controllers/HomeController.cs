using Archivos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Archivos.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ProcesarNombresArchivos([FromBody]ProcesarNombresRequest request)
        {
            var result = new List<ArchivoDTO>();
            foreach (var archivo in request.NombresArchivos)
            {
                result.Add(new ArchivoDTO { 
                    Nombre= archivo.Split('.')[0],
                    TipoArchivo = archivo.Split('.')[1]
                });
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult GuardarArchivos([FromForm]GuardarArchivoRequest request)
        {
            foreach (var archivo in request.Archivos)
            {
                // service.HacerAlgoConArchivo(archivo);
            }
            return Ok(true);
        }

        [HttpPost]
        public ActionResult GuardarInformacionArchivos([FromBody] GuardarInformacionArchivosRequest request)
        {
            foreach (var archivo in request.Archivos)
            {
                // service.HacerAlgoConInfoArchivos(archivo);
            }
            return Ok(true);
        }
    }
}
