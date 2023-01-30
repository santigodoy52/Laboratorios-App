using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_Laboratorios.Models
{
    public class Laboratorio
    {
        public int idAula { get; set; }
        public int numero { get; set; }

        public Laboratorio() { }

        public Laboratorio(int Id, int Numero)
        {
            idAula = Id;
            numero = Numero;
        }
        public Laboratorio(int Numero)
        {
            numero = Numero;
        }

    }

    public class Profesor
    {
        public int idProfesor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }

        public Profesor() { }

        public Profesor(int id, string Nombre, string Apellido, int Dni)
        {
            idProfesor = id;
            nombre = Nombre;
            apellido = Apellido;
            dni = Dni;
        }
        public Profesor(string Nombre, string Apellido, int Dni)
        {
            nombre = Nombre;
            apellido = Apellido;
            dni = Dni;
        }

    }

    public class Materias
    {
        public int idMateria { get; set; }
        public int idCarrera { get; set; }
        public string nombre { get; set; }

        public Materias() { }

        public Materias(int idMat, int idCar, string Nombre)
        {
            idMateria = idMat;
            idCarrera = idCar;
            nombre = Nombre;
        }
        public Materias(int idCar, string Nombre)
        {
            idCarrera = idCar;
            nombre = Nombre;
        }
    }

    public class Carrera
    {
        public int idCarrera { get; set; }
        public string nombre { get; set; }
        public int anio { get; set; }

        public Carrera() { }

        public Carrera(int idcar, string Nombre , int Anio)
        {
            idCarrera = idcar;
            nombre = Nombre;
            anio = Anio;
        }
        public Carrera( string Nombre, int Anio)
        {
            nombre = Nombre;
            anio = Anio;
        }
    }

    public class Horario
    {
        public int idHorario { get; set; }
        public int idCarrera { get; set; }
        public int idMateria { get; set; }
        public int idAula { get; set; } 
        public int idProfesor { get; set; }
        public string dia { get; set; }
        public string horas { get; set; }

        public Horario() { }

        public Horario(int idHor,int idCar ,int idMat,int idAul, int idPro, string Dia , string Horas)
        {
            idHorario = idHor;
            idCarrera = idCar;
            idMateria = idMat;
            idAula = idAul;
            idProfesor = idPro;
            dia = Dia;
            horas = Horas;
        }
        public Horario( int idCar, int idMat, int idAul,int idPro, string Dia, string Horas)
        {
            idCarrera = idCar;
            idMateria = idMat;
            idAula = idAul;
            idProfesor = idPro;
            dia = Dia;
            horas = Horas;
        }
    }
        
    public class Join
    {
        public string dia { get; set; }
        public string horas { get; set; }
        public int aula { get; set; }
        public string nombre { get; set; }
        public string materia { get; set; }

        public Join() { }

        public Join(string Dia ,string Horas, int Aula, string Nombre , string Materia)
        {
            dia = Dia;
            horas = Horas;
            aula = Aula;
            nombre = Nombre;
            materia = Materia;
        }
    }
    public class TablaHorarios
    {
        public string carrera { get; set; }
        public string materia { get; set; }
        public int laboratorio { get; set; }
        public string profesor { get; set; }
        public string dia { get; set; }
        public string horas { get; set; }

        public TablaHorarios() { }

        public TablaHorarios(string Carrera, string Materia, int Laboratorio, string Profesor,string Dia , string Horas)
        {
            carrera = Carrera;
            materia = Materia;
            laboratorio = Laboratorio;
            profesor = Profesor;
            dia = Dia;
            horas = Horas;
        }
    }
}