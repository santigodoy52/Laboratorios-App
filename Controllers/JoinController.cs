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
    public class JoinController : ApiController
    {
        // GET: api/Laboratorios
        public IEnumerable<Join> Get(string dia)
        {
            GestorJoin gJoin = new GestorJoin();
            return gJoin.getJoin(dia);
        }

        // GET: api/Laboratorios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Laboratorios
        //public bool Post([FromBody] Join join)
        //{
        //    GestorJoin gJoin = new GestorJoin();

        //    bool respuesta = gJoin.AddJoin(join);

        //    return respuesta;
        //}

        //// PUT: api/Laboratorios/5
        //public bool Put(int id, [FromBody] Join join)
        //{
        //    GestorJoin gJoin = new GestorJoin();

        //    bool respuesta = gJoin.UpdateJoin(id, join);

        //    return respuesta;
        //}

        //// DELETE: api/Laboratorios/5
        //public bool Delete(int id)
        //{
        //    GestorJoin gJoin = new GestorJoin();

        //    bool respuesta = gHorarios.deleteHorario(id);

        //    return respuesta;
        //}
    }
}
