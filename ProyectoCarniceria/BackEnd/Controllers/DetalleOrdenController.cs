﻿using DAL.Interfaces;
using DAL.Implementations;
using Microsoft.AspNetCore.Mvc;
using ProyectoCarniceria;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{

    

    [Route("api/[controller]")]
    [ApiController]
    public class DetalleOrdenController : ControllerBase
    {

        private IDALDetalleOrden DALDetalleOrden;

        public DetalleOrdenController()
        {
            DALDetalleOrden = new DetalleOrdenDALImpl(new ProyectoCarniceria.CarniceriaContext());

        }

        // GET: api/<DetalleOrdenController>
        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<DetalleOrden> detalles = DALDetalleOrden.GetAll();


            return new JsonResult(detalles);
        }

        // GET api/<DetalleOrdenController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            DetalleOrden detalleOrden;
            detalleOrden = DALDetalleOrden.Get(id);

            return new JsonResult(detalleOrden);
        }

        // POST api/<DetalleOrdenController>
        [HttpPost]
        public JsonResult Post([FromBody] DetalleOrden detalleOrden)
        {
            DALDetalleOrden.Add(detalleOrden);
            return new JsonResult(detalleOrden);
        }


        // PUT api/<DetalleOrdenController>/5
        [HttpPut("{id}")]
        public JsonResult Put([FromBody] DetalleOrden detalleOrden)
        {
            DALDetalleOrden.Update(detalleOrden);
            return new JsonResult(detalleOrden);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            DetalleOrden category = new DetalleOrden {  IdOrden = id };
            DALDetalleOrden.Remove(category);

            return new JsonResult(category);
        }
    }
}
