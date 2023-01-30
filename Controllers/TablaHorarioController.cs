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
    public class TablaHorarioController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "GET,POST,PUT,DELETE,OPTIONS")]
        public class TablaHorariosController : ApiController
        {
            // GET: api/Laboratorios
            public IEnumerable<TablaHorarios> Get()
            {
                GestorTablaHorarios gtablaHorarios = new GestorTablaHorarios();
                return gtablaHorarios.getTablaHorario();
            }

            // GET: api/Laboratorios/5
            public string Get(int id)
            {
                return "value";
            }
        }
    }
}
