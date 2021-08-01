using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProfesorDato
    {







        public static void AltaProfesores(Profesor profesor)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                bd.Profesor.Add(profesor);
                bd.SaveChanges();
                
            }

        }

        public static void BajaProfesores(Profesor profesor)
        {
           
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
               
                bd.Profesor.Remove(bd.Profesor.Find(profesor.Legajo));
                bd.SaveChanges();

            }

        }

        public static List<Profesor> CargarProfesores()
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                return bd.Profesor.ToList();
            }

        }

        public static Profesor BuscarxLegajo(int legajo)
        {
            
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
               
                var query = (from p in bd.Profesor
                             where p.Legajo == legajo
                             select p).Single();

                return query;
            }
       

        }

        public static List<Profesor> BuscarProfesorxNombre(string nomb)
        {
            // Contains permite buscar objetos que se parezcan al parametro que esty mandando en este caso el nombre del docente
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from p in bd.Profesor
                            where p.NombreYApellido.Contains(nomb)
                            select p;

                return query.ToList();
            }

        }

        //Lista de materias que dicta un docente
        public static List<Materia> MateriasDictadas(int legajo)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from p in bd.Materia
                            where p.Legajo==legajo
                            select p;

                return query.ToList();
            }

        }


        public static void ModificarProfesor(Profesor profesor)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from m in bd.Profesor
                             where m.Legajo == profesor.Legajo
                             select m).Single();

                query.NombreYApellido = profesor.NombreYApellido;
                query.Direccion = profesor.Direccion;
                query.Telefono = profesor.Telefono;
                query.DNI = profesor.DNI;

                bd.SaveChanges();

            }

        }


    }
}
