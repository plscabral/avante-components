using AvanteComponents.Api.Models.Financeiro;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace AvanteComponents.Api.Controllers.Financeiro
{
    [ApiController]
    [Route("api/financeiro/despesa")]
    public class DespesaController : ControllerBase
    {
        [HttpPost("salvar/documento")]
        public IActionResult SalvarDocumentos([FromForm] DocumentoDespesaModel model)
        {
            string path = @"D:\_ged\Modulo\Financeiro\Despesa\";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (FileStream fileStream = System.IO.File.Create(path + model.File.FileName))
                {
                    model.File.CopyTo(fileStream);
                    fileStream.Flush();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(201);
        }
    }
}
