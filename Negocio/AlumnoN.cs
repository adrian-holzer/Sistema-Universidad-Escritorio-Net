using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class AlumnoN
    {


        public static void AltaAlumno(Alumno alumno)
        {
            AlumnoDato.AltaAlumno(alumno);

        }






        public static void BajaAlumno(Alumno alumno)
        {


            AlumnoDato.BajaAlumno(alumno);

        }






        public static void ModificarAlumno(Alumno alumno)
        {


            if (Existe(alumno))
            {
                AlumnoDato.ModificarAlumno(alumno);

            }
        }

        private static bool Existe(Alumno al)
        {
            if (AlumnoDato.BuscarAlumnoxMatricula(al.Matricula).Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


            public static List<Alumno> CargarAlumnos()
        {
            List<Alumno> list = AlumnoDato.CargarAlumnos();

            if (list.Count() > 0)
            {
                return list;
            }

            else
            {
                return null;
            }

        }

        public static List<Alumno> BuscarAlumnoxNombre(string nomb)
        {

            return AlumnoDato.BuscarAlumnoxNombre(nomb);

        }
        public static List<Alumno> BuscarAlumnoxMatricula(int matricula)
        {

            return AlumnoDato.BuscarAlumnoxMatricula(matricula);


        }
    }
}
