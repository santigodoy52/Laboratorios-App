using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_Laboratorios.Models
{
    public class GestorHorarios
    {
        public List<Horario> getHorario()
        {
            List<Horario> lista = new List<Horario>();
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Horario_All";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    int idCarrera = dr.GetInt32(1);
                    int idMateria = dr.GetInt32(2);
                    int idAula = dr.GetInt32(3);
                    int idProfesor = dr.GetInt32(4);
                    string dia = dr.GetString(5).Trim();
                    string horas = dr.GetString(6).Trim();

                    Horario horario = new Horario(id, idCarrera, idMateria,idAula,idProfesor, dia , horas);
                    lista.Add(horario);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public bool addHorario(Horario horario)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Horario_Add";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCarrera", horario.idCarrera);
                cmd.Parameters.AddWithValue("@idMateria", horario.idMateria);
                cmd.Parameters.AddWithValue("@idAula", horario.idAula);
                cmd.Parameters.AddWithValue("@idProfesor", horario.idProfesor);
                cmd.Parameters.AddWithValue("@dia", horario.dia);
                cmd.Parameters.AddWithValue("@hora", horario.horas);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }
        }


        public bool UpdateHorario(int id, Horario horario)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Horario_Update";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@idCarrera", horario.idCarrera);
                cmd.Parameters.AddWithValue("@idMateria", horario.idMateria);
                cmd.Parameters.AddWithValue("@idAula", horario.idAula);
                cmd.Parameters.AddWithValue("@idProfesor", horario.idProfesor);
                cmd.Parameters.AddWithValue("@dia", horario.dia);
                cmd.Parameters.AddWithValue("@hora", horario.horas);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }
        }

        public bool deleteHorario(int idHor)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "Horario_Delete";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", idHor);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }
        }
    }
}