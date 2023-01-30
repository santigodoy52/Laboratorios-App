using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_Laboratorios.Models
{
    public class GestorJoin
    {
        public List<Join> getJoin(string pDia)
        {
            List<Join> lista = new List<Join>();
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SP_getMainTable";
                cmd.Parameters.Add("@dia", SqlDbType.VarChar);
                cmd.Parameters["@dia"].Value = pDia;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string dia = dr.GetString(0).Trim();
                    string horas = dr.GetString(1).Trim();
                    int aula = dr.GetInt32(2);
                    string nombre = dr.GetString(3).Trim();
                    string materia = dr.GetString(4).Trim();

                    Join join = new Join(dia, horas, aula , nombre , materia);
                    lista.Add(join);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
    }
}