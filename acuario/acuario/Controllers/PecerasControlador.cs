using Microsoft.AspNetCore.Mvc;
using acuario.Entidades;

namespace acuario.Controllers
{
    [ApiController]
    [Route("api/peceras")]
    public class PecerasControlador : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<Peceras>> Get()
        {
            return new List<Peceras>()
            {
                new Peceras() {Id_Pecera = 1, Id_local = 1, capacidad = 200, tamaño = 3, temperatura = 5, ph = 7},
                new Peceras() {Id_Pecera = 2, Id_local = 2, capacidad = 300, tamaño = 4, temperatura = 20, ph = 8}

            };
        }


        [HttpPost]
        public ActionResult<List<Peceras>> Post(Peceras nuevoPecera)
        {
            return CreatedAtAction(nameof(Get), new { id = nuevoPecera.Id_local }, nuevoPecera);
        }


        [HttpPut("{id}")]
        public ActionResult<List<Peceras>> Put(int id, Peceras peceraActualizado)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Peceras>> Delete(int id)
        {
            return NoContent();
        }


    }
}
