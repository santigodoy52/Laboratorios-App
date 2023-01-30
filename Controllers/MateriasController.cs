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
    public class MateriasController : ApiController
    {
        // GET: api/Laboratorios
        public IEnumerable<Materias> Get()
        {
            GestordeMaterias gMaterias = new GestordeMaterias();
            return gMaterias.getMaterias();
        }

        // GET: api/Laboratorios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Laboratorios
        public bool Post([FromBody] Materias materia)
        {
            GestordeMaterias gMaterias = new GestordeMaterias();

            bool respuesta = gMaterias.addMateria(materia);

            return respuesta;
        }

        // PUT: api/Laboratorios/5
        public bool Put(int id, [FromBody] Materias materias)
        {
            GestordeMaterias gMaterias = new GestordeMaterias();

            bool respuesta = gMaterias.UpdateMateria(id, materias);

            return respuesta;
        }

        // DELETE: api/Laboratorios/5
        public bool Delete(int id)
        {
            GestordeMaterias gMaterias = new GestordeMaterias();

            bool respuesta = gMaterias.deleteMateria(id);

            return respuesta;
        }
    }
}
