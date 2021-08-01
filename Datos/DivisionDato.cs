using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DivisionDato
    {


        public static List<Division> ListarDivisiones(Curso curso)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = from d in bd.Division
                            where d.idCurso == curso.idCurso
                            select d;

                return query.ToList();


            }

        }

        public static Division BuscarDivisionporID(int idDivision)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from m in bd.Division
                             where m.idDivision == idDivision
                             select m).Single();

                return query;
            }

        }

        public static void ModificarDivision(Division division)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from d in bd.Division
                             where d.idDivision == division.idDivision
                             select d).Single();

                query.NombreDivision = division.NombreDivision;
                
                bd.SaveChanges();
            }


        }
    }
    }

