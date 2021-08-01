using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AlumnoDato
    {

        public static void AltaAlumno(Alumno alumno)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Alumno.Add(alumno);
                bd.SaveChanges();

            }

        }



        public static void BajaAlumno(Alumno alumno)
        {


            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from a in bd.Alumno
                             where a.Matricula == alumno.Matricula
                             select a).Single();
                bd.Alumno.Remove(query);
                bd.SaveChanges();

            }
        }



        public static void ModificarAlumno(Alumno alumno)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from a in bd.Alumno
                             where a.Matricula == alumno.Matricula
                             select a).Single();

                query.NombreYApellido = alumno.NombreYApellido;
                query.Direccion = alumno.Direccion;
                query.Telefono = alumno.Telefono;

                bd.SaveChanges();

            }

        }




        public static List<Alumno> CargarAlumnos()
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                return bd.Alumno.ToList();
            }

        }


        public static List<Alumno> BuscarAlumnoxNombre(string nomb)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from a in bd.Alumno
                            where a.NombreYApellido.Contains(nomb)
                            select a;

                return query.ToList();
            }

        }

        public static List<Alumno> BuscarAlumnoxMatricula(int matricula)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from a in bd.Alumno
                            where a.Matricula.ToString().Contains(matricula.ToString())
                            select a;

                return query.ToList();
            }

        }






    }
}
