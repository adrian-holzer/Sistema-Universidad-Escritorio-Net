using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MateriaDato
    {





        public static void AltaMateria(Materia materia)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Materia.Add(materia);
                bd.SaveChanges();

            }

        }

        public static void BajaMateria(Materia materia)
        {


            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Materia.Remove(materia);
                bd.SaveChanges();

            }
        }


        public static void BajaMateriaxID(int idMateria)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Materia.Remove(bd.Materia.Find(idMateria));
                bd.SaveChanges();

            }

        }


        public static List<Materia> CargarMaterias()
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                return bd.Materia.ToList();
            }

        }








        public static bool Existe(string nombre)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from mat in bd.Materia where mat.Nombre == nombre select mat).Count();
                if (query == 0)
                    return false;
                else
                    return true;
            }
        }

        public static List<Materia> BuscarMateriaxNombre(string nomb)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from m in bd.Materia
                            where m.Nombre.Contains(nomb)
                            select m;

                return query.ToList();
            }

        }



        








        public static void ModificarMateria(Materia materia)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from m in bd.Materia
                             where m.idMateria == materia.idMateria
                             select m).Single();

                query.Nombre = materia.Nombre;
                query.Legajo = materia.Legajo;
                
                bd.SaveChanges();

            }

        }



        public static Materia BuscarMateriaPorID(int idMateria)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from m in bd.Materia
                             where m.idMateria == idMateria
                             select m).Single();
              
                return query;

            }



        }

       
    }
}
