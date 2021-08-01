using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
  public  class CorrelativaDato
    {

        

        public static void AltaCorrelativa(Correlativa correlativa)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Correlativa.Add(correlativa);
                bd.SaveChanges();

            }

        }


        public static void BajaCorrelativa(Correlativa correlativa)
        {


            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.Correlativa.Remove(correlativa);
                bd.SaveChanges();

            }


        }

        public static void BajaPorIDCorrelativa(int idCorrelativa)
        {


            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from c in bd.Correlativa where c.idCorrelativa == idCorrelativa select c).Single();
                bd.Correlativa.Remove(query);
                bd.SaveChanges();

            }


        }

        public static void EliminarxIDMateria(int idMateria)
        {
            //Elimina todas las correlativas

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                List<Correlativa> listCorr = new List<Correlativa>();

                listCorr = bd.Correlativa.Where(c => c.idMateria == idMateria).ToList();

                foreach (Correlativa c in listCorr)
                {

                    bd.Correlativa.Remove(c);
                    bd.SaveChanges();

                }

               

            }
        }



            public static void EliminarxNombreCorrelativa(string nombre)
            {


                using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
                {
                    List<Correlativa> listCorr = new List<Correlativa>();

                    listCorr = bd.Correlativa.Where(c => c.Nombre == nombre).ToList();

                    foreach (Correlativa c in listCorr)
                    {

                        bd.Correlativa.Remove(c);
                      bd.SaveChanges();

                    }

                    

                }





            }

        public static List<Correlativa> ListaCorrelativas(int idMateria)
        {


            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {


                var query = from c in bd.Correlativa
                            where c.idMateria == idMateria
                            select c;

                return query.ToList();



            }


        }


      




        public static void ModificarCorrelativa(Correlativa correlativa)
        {
           using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {


                var query = ( from c in bd.Correlativa
                            where c.idCorrelativa == correlativa.idCorrelativa 
                            select c).Single();

               
                
                query.Requisito = correlativa.Requisito;
                
                bd.SaveChanges();
                 }

            }

        }




    }

