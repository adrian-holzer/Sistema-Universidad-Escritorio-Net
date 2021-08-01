using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FinalDato
    {


        public static void AltFinal(Final final)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Final.Add(final);
                bd.SaveChanges();

            }

        }


        public static void BajaFinales(int idCursoMateria )
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from f in bd.Final where f.idCursoMateria == idCursoMateria select f);

                foreach (Final f in query.ToList())
                {
                    bd.Final.Remove(f);
                    bd.SaveChanges();
                }
            }

        }



        public static Final BuscarFinal(int idCursoMateria)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from f in bd.Final where f.idCursoMateria == idCursoMateria && f.EstadoEFinal=="Inscripto" select f).Single();

                return query;

            }



        }

        public static List<Final> ListarFinales(int idCursoMateria)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from f in bd.Final where f.idCursoMateria == idCursoMateria select f);

                return query.ToList();

            }



        }



        public static void ActualizarFinal(Final final)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.Final where cm.intIdFinal == final.intIdFinal select cm).Single();


                query.EstadoEFinal = final.EstadoEFinal;
                query.NotaExamen = final.NotaExamen;
                bd.SaveChanges();

            }



        }







    }
}
