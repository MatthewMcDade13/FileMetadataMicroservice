using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMetadataMicroservice.Controllers
{
    public class FileController : Controller
    {
        [HttpPost]
        public IActionResult GetFileSize(IFormFile file)
        {
            if (file == null)
            {
                return BadRequest();
            }

            return Json(new { Size = file.Length });
        }
    }
}
