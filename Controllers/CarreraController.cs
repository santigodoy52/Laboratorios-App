using Back_Laboratorios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Back_Laboratorios.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
    public class CarreraController : ApiController
    {
        // GET: api/Laboratorios
        public IEnumerable<Carrera> Get()
        {
            GestorCarreras gCarreras = new GestorCarreras();
            return gCarreras.getCarreras();
        }

        // GET: api/Laboratorios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Laboratorios
        public bool Post([FromBody] Carrera carrera)
        {
            GestorCarreras gCarreras = new GestorCarreras();

            bool respuesta = gCarreras.addCarrera(carrera);

            return respuesta;
        }

        // PUT: api/Laboratorios/5
        public bool Put(int id, [FromBody] Carrera carrera)
        {
            GestorCarreras gCarreras = new GestorCarreras();

            bool respuesta = gCarreras.UpdateCarrera(id,carrera);

            return respuesta;
        }

        // DELETE: api/Laboratorios/5
        public bool Delete(int id)
        {
            GestorCarreras gCarreras = new GestorCarreras();

            bool respuesta = gCarreras.deleteCarrera(id);

            return respuesta;
        }
    }
}
