using DAL.Implementations;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProyectoCarniceria;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetaController : ControllerBase
    {

        private IRecetaDAL recetaDAL;

        public RecetaController()
        {
            recetaDAL = new RecetaDALImpl(new ProyectoCarniceria.CarniceriaContext());

        }

        // GET: api/<RecetaController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Receta> recetas = recetaDAL.GetAll();


            return new JsonResult(recetas);
        }

        // GET api/<RecetaController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Receta receta;
            receta = recetaDAL.Get(id);

            return new JsonResult(receta);
        }

        // POST api/<RecetaController>
        [HttpPost]
        public JsonResult Post([FromBody] Receta receta)
        {
            recetaDAL.Add(receta);
            return new JsonResult(receta);
        }



        // PUT api/<RecetaController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Receta receta)
        {
            recetaDAL.Update(receta);
            return new JsonResult(receta);
        }

        // DELETE api/<RecetaController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Receta receta = new Receta { IdReceta = id };
            recetaDAL.Remove(receta);

            return new JsonResult(receta);
        }
    }
}