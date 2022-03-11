using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Api.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        Conexion con = new Conexion();
        // GET: api/<ProductosController>
        [HttpGet]
        public List<Productos>  /*IEnumerable<string>*/ Get()
        {
            //return new string[] { "value1", "value2" };
            List<Productos> pr = new List<Productos>();
            try {
                
                using (var db = new MySqlConnection(con.conexion))
            {
                var sql = "SELECT * FROM productos";
                var result = db.Query<Productos>(sql);
               
                foreach(var p in result)
                {
                    Productos pl = new Productos();
                    pl.nombre = p.nombre;
                    pl.rowid = p.rowid;
                    pl.descripcion = p.descripcion;
                    pl.precio = p.precio;

                    pr.Add(pl);
                }
                return pr;
            }
            }catch(Exception e)
            {
                //return e;
            }
            return pr;
            //return View();

        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
