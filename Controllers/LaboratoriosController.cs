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

    [EnableCors(origins: "*", headers:"*",methods:"GET,POST,PUT,DELETE,OPTIONS")]
    public class LaboratoriosController : ApiController
    {
        // GET: api/Laboratorios
        public IEnumerable<Laboratorio> Get()
        {
            GestordeAulas gaulas = new GestordeAulas();
            return gaulas.getLaboratorios();
        }

        // GET: api/Laboratorios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Laboratorios
        public bool Post([FromBody]Laboratorio laboratorio)
        {
            GestordeAulas gaulas = new GestordeAulas();

            bool respuesta = gaulas.addLaboratorio(laboratorio);

            return respuesta;
        }

        // PUT: api/Laboratorios/5
        public bool Put(int id, [FromBody] Laboratorio laboratorio)
        {
            GestordeAulas gaulas = new GestordeAulas();

            bool respuesta = gaulas.UpdateLaboratorio(id,laboratorio);

            return respuesta;
        }

        // DELETE: api/Laboratorios/5
        public bool Delete(int id)
        {
            GestordeAulas gaulas = new GestordeAulas();

            bool respuesta = gaulas.deleteLaboratorio(id);

            return respuesta;
        }
    }
}
