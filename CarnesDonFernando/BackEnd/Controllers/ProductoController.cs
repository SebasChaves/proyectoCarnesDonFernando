using DAL.Interfaces;
using DAL.Implementations;
using Microsoft.AspNetCore.Mvc;
using Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private IProductoDAL productoDAL; 

        public ProductoController()
        {
            productoDAL =  new ProductoDALImpl(new Entities.proyectoCarnesDonFernandoContext());

        }

        // GET: api/<ProductoController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Producto> productos = productoDAL.GetAll();


            return new JsonResult(productos);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Producto producto;
            producto = productoDAL.Get(id);

            return new JsonResult(producto);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public JsonResult Post([FromBody] Producto producto)
        {
            productoDAL.Add(producto);
            return new JsonResult(producto);
        }

        // PUT api/<ProductoController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Producto producto)
        {
            productoDAL.Update(producto);
            return new JsonResult(producto);
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Producto category = new Producto { IdProducto = id };
            productoDAL.Remove(category);

            return new JsonResult(category);
        }
    }
}
