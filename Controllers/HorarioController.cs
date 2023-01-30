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
    public class HorarioController : ApiController
    {
        // GET: api/Laboratorios
        public IEnumerable<Horario> Get()
        {
            GestorHorarios gHorarios = new GestorHorarios();
            return gHorarios.getHorario();
        }

        // GET: api/Laboratorios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Laboratorios
        public bool Post([FromBody] Horario horario)
        {
            GestorHorarios gHorarios = new GestorHorarios();

            bool respuesta = gHorarios.addHorario(horario);

            return respuesta;
        }

        // PUT: api/Laboratorios/5
        public bool Put(int id, [FromBody] Horario horario)
        {
            GestorHorarios gHorarios = new GestorHorarios();

            bool respuesta = gHorarios.UpdateHorario(id, horario);

            return respuesta;
        }

        // DELETE: api/Laboratorios/5
        public bool Delete(int id)
        {
            GestorHorarios gHorarios = new GestorHorarios();

            bool respuesta = gHorarios.deleteHorario(id);

            return respuesta;
        }
    }
}
