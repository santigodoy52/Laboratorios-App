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
    public class ProfesoresController : ApiController
    {
        // GET: api/Laboratorios
        public IEnumerable<Profesor> Get()
        {
            GestorProfesores gProfesores = new GestorProfesores();
            return gProfesores.getProfesor();
        }

        // GET: api/Laboratorios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Laboratorios
        public bool Post([FromBody] Profesor profesor)
        {
            GestorProfesores gProfesores = new GestorProfesores();

            bool respuesta = gProfesores.addProfesor(profesor);

            return respuesta;
        }

        // PUT: api/Laboratorios/5
        public bool Put(int id, [FromBody] Profesor profesor)
        {
            GestorProfesores gProfesores = new GestorProfesores();

            bool respuesta = gProfesores.UpdateProfesor(id, profesor);

            return respuesta;
        }

        // DELETE: api/Laboratorios/5
        public bool Delete(int id)
        {
            GestorProfesores gProfesores = new GestorProfesores();

            bool respuesta = gProfesores.deleteProfesor(id);

            return respuesta;
        }
    }
}

