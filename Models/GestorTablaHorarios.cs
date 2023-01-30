using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_Laboratorios.Models
{
    public class GestorTablaHorarios
    {
        public List<TablaHorarios> getTablaHorario()
        {
            List<TablaHorarios> lista = new List<TablaHorarios>();
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SP_getHorarios";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string Carrera = dr.GetString(0).Trim();
                    string Materia = dr.GetString(1).Trim();
                    int Laboratorio = dr.GetInt32(2);
                    string Profesor = dr.GetString(3).Trim();
                    string dia = dr.GetString(4).Trim();
                    string horas = dr.GetString(5).Trim();

                    TablaHorarios tablaHorario = new TablaHorarios(Carrera, Materia, Laboratorio, Profesor, dia, horas);
                    lista.Add(tablaHorario);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
    }
}