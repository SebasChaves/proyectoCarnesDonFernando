using DAL.Implementations;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Entities;
    
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private IIngredienteDAL ingredienteDAL;
        private readonly ILogger<IngredienteController> logger;

        public IngredienteController(ILogger<IngredienteController> logger)
        {
            ingredienteDAL = new IngredienteDALImpl(new proyectoCarnesDonFernandoContext());
            this.logger = logger;
        }

        // GET: api/<IngredienteController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Ingrediente> ingredientes = ingredienteDAL.GetAll();


            return new JsonResult(ingredientes);
        }

        // GET api/<IngredienteController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Ingrediente ingrediente;
            ingrediente = ingredienteDAL.Get(id);

            return new JsonResult(ingrediente);
        }

        // POST api/<IngredienteController>
        [HttpPost]
        public JsonResult Post([FromBody] Ingrediente ingrediente)
        {
            ingredienteDAL.Add(ingrediente);
            return new JsonResult(ingrediente);
        }



        // PUT api/<IngredienteController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Ingrediente ingrediente)
        {
            ingredienteDAL.Update(ingrediente);
            return new JsonResult(ingrediente);
        }

        // DELETE api/<Ingredienteontroller>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Ingrediente ingrediente = new Ingrediente { IdIngrediente = id };
            ingredienteDAL.Remove(ingrediente);

            return new JsonResult(ingrediente);
        }
    }
}
