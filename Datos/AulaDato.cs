using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AulaDato
    {




        public static List<Aula> ListarAulas()
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = from m in bd.Aula
                            
                            select m;

                return query.ToList();

            }



        }

        public static Aula BuscarAula(int idAula)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from m in bd.Aula where m.idAula==idAula

                            select m).Single();

                return query;

            }



        }



        public static void ModificarAula(Aula aula)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from a in bd.Aula
                             where a.idAula == aula.idAula
                             select a).Single();

                query.NombreAula = aula.NombreAula;
                query.Proyector = aula.Proyector;
                query.Capacidad = aula.Capacidad;
                query.ConexionRed = aula.ConexionRed;

                bd.SaveChanges();

            }

        }


    }
}
