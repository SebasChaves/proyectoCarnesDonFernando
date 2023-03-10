using DAL.Interfaces;
using DAL.Implementations;
using Microsoft.AspNetCore.Mvc;
using Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class MensajesContactoController : ControllerBase
    {

        private IDALMensajesContacto DALMensajesContacto;

        public MensajesContactoController()
        {
            DALMensajesContacto = new MensajesContactoDALImpl(new Entities.proyectoCarnesDonFernandoContext());

        }

        // GET: api/<MensajesContactoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<MensajesContacto> mensajes = DALMensajesContacto.GetAll();


            return new JsonResult(mensajes);
        }

        // GET api/<MensajesContactoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            MensajesContacto mensajesContacto;
            mensajesContacto = DALMensajesContacto.Get(id);

            return new JsonResult(mensajesContacto);
        }

        // POST api/<MensajesContactoController>
        [HttpPost]
        public JsonResult Post([FromBody] MensajesContacto mensajesContacto)
        {
            DALMensajesContacto.Add(mensajesContacto);
            return new JsonResult(mensajesContacto);
        }


        // PUT api/<MensajesContactoController>/5
        [HttpPut("{id}")]
        public JsonResult Put([FromBody] MensajesContacto mensajesContacto)
        {
            DALMensajesContacto.Update(mensajesContacto);
            return new JsonResult(mensajesContacto);
        }

        // DELETE api/<MensajesContactoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            MensajesContacto mensajes = new MensajesContacto { IdMensaje = id };
            DALMensajesContacto.Remove(mensajes);

            return new JsonResult(mensajes);
        }
    }
}
