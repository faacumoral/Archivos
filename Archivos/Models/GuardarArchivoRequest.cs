using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archivos.Models
{
    public class GuardarArchivoRequest
    {
        public IList<IFormFile> Archivos { get; set; }
    }
}
