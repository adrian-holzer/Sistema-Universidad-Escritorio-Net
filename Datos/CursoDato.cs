using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CursoDato
    {



       public static List<Curso> ListarCursosPorNombre()
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from c in bd.Curso  select c);

                return query.ToList();
            }

        }

        public static Curso BuscaCursoPorID(int idCurso)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from c in bd.Curso where c.idCurso==idCurso select c).Single();

                return query;
            }
        }

        public static Curso BuscaCursoPorNombre(string nombreCurso)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from c in bd.Curso where c.Nombre == nombreCurso select c).Single();

                return query;
            }
        }


        public static Curso BuscaCursoPorAula(int  idAula)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from c in bd.Curso where c.idAula == idAula select c).Single();

                return query;
            }
        }






        public static List<Materia> ListarMateriasPorCurso(Curso curso)
        {
           
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from m in bd.Materia
                            where m.IdCurso==curso.idCurso
                            select m;

                return query.ToList();

            }



        }


       




    }
}
