using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parcial2.Models;
using Parcial2.Repository;
using Parcial2.Context;
using static Parcial2.Repository.MedicamentosDAO;


namespace Farmacia_Unab.Controllers
{
    [Route("api/")]
    [ApiController]
    public class MedicamentoController : ControllerBase
    {
        private MedicamentoDAO _medicamento = new MedicamentoDAO();

        [HttpGet("listar")]
        public List<Medicamento> Listar()
        {
            return _medicamento.Select();
        }

        [HttpGet("obtener/{id}")]
        public Medicamento? ObtenerPorId(int id)
        {
            return _medicamento.GetId(id);
        }

        [HttpPost("insertar")]
        public IActionResult Insertar([FromBody] Medicamento medicamento)
        {
            if (medicamento == null)
            {
                return BadRequest("Datos inválidos.");
            }

            var resultado = _medicamento.Insertar(medicamento);
            return resultado ? Ok("Medicamento guardado correctamente.") : BadRequest("Error al guardar.");
        }

        [HttpPut("actualizar")]
        public IActionResult Actualizar([FromBody] Medicamento medicamento)
        {
            if (medicamento == null)
            {
                return BadRequest("Datos inválidos.");
            }

            var resultado = _medicamento.Actualizar(medicamento);
            return resultado ? Ok("Medicamento actualizado correctamente.") : BadRequest("Error al actualizar.");
        }


        [HttpDelete("eliminar/{id}")]
        public string Eliminar(int id)
        {
            var resultado = _medicamento.Eliminar(id);
            return resultado ? "Medicamento eliminado correctamente." : "Error al eliminar.";
        }
    }
}
