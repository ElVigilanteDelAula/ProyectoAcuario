using Microsoft.AspNetCore.Mvc;
using acuario.Entidades;

namespace acuario.Controllers
{
    [ApiController]
    [Route("ap<i/acuario")]
    public class AcuarioControlador : ControllerBase
    {
        [HttpGet]


        public ActionResult<List<Acuario>> Get()
        {
            return new List<Acuario>()
            {
                new Acuario() {Id_local = 1, Nombre = "Acuario Nemo 01", ubicacion = "Nuevo leon, Apodaca, Sta rosa #112", f_inauguracion = "24/02/2006"},
                new Acuario() {Id_local = 2, Nombre = "Acuario Nemo 02", ubicacion = "Nuevo leon, San Nicolas, Cosmos #781", f_inauguracion = "16/06/2017"}

            };

        }

        [HttpPost]
        public ActionResult <List<Acuario>> Post(Acuario nuevoAcuario)
        {
           
            return CreatedAtAction(nameof(Get), new { id = nuevoAcuario.Id_local }, nuevoAcuario);
        }


        [HttpPut("{id}")]
        public ActionResult <List<Acuario>> Put(int id, Acuario acuarioActualizado)
        {
            

            return NoContent();


        }

        [HttpDelete("{id}")]
        public ActionResult<List<Acuario>> Delete(int id)
        {
            
            
            return NoContent();
        }


    }
}
