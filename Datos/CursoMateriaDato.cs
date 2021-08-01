using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public  class CursoMateriaDato
    {



        public static void AltaCursoMateria(CursoMateria CursoMateria)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                bd.CursoMateria.Add(CursoMateria);
                bd.SaveChanges();

            }

        }


        public static void BajaIdMateria(int idMateria)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                List<CursoMateria> listCorr = new List<CursoMateria>();

                listCorr = bd.CursoMateria.Where(cm => cm.idMateria == idMateria).ToList();

                foreach (CursoMateria c in listCorr)
                {

                    bd.CursoMateria.Remove(c);
                    bd.SaveChanges();

                }

            }
        }





        public static void BajaxIDCurso_Materia(int idCursoMateria)
        {
            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {
                var query = (from cm in bd.CursoMateria where cm.idCursoMateria == idCursoMateria select cm).Single();

                bd.CursoMateria.Remove(query);
                bd.SaveChanges();

                

            }
        }




        public static List<CursoMateria> listaCursoMateria(int idDivision, int idMateria,string estado)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.idDivision== idDivision && cm.idMateria== idMateria && cm.Estado==estado select cm).ToList();

                return query;

            }



        }


        public static List<CursoMateria> listaCursoMateria( int idMateria)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.idMateria == idMateria select cm).ToList();

                return query;

            }



        }



        public static List<CursoMateria> listaCursoMateria_Matricula_Estado(int matricula, string estado)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.Matricula == matricula && cm.Estado == estado  select cm).ToList();

                return query;

            }



        }


        public static CursoMateria listaCursoMateria_Matricula_Materia(int matricula, int idMateria)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.Matricula == matricula && cm.idMateria == idMateria select cm).Single();

                return query;

            }



        }






        public static List<CursoMateria> listaCursoMateriaPorMatricula(int matricula)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.Matricula == matricula select cm).ToList();

                return query;

            }



        }



        public static List<CursoMateria> listaCursoMateriaPorIDMateria(int idMateria,string estado)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.idMateria == idMateria && cm.Estado==estado select cm).ToList();

                return query;

            }



        }


        public static CursoMateria BuscarCursoMateriaxID(int idCursoMateria)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.idCursoMateria == idCursoMateria select cm).Single();

                return query;
            }

        }



            public static void RegistrarNotas(CursoMateria CursoMat)
        {

            using (DB_UniversidadEntities bd = new DB_UniversidadEntities())
            {

                var query = (from cm in bd.CursoMateria where cm.idCursoMateria == CursoMat.idCursoMateria select cm).Single();


                query.PrimerParcial =CursoMat.PrimerParcial ;
                query.SegundoParcial = CursoMat.SegundoParcial;
                query.TercerParcial = CursoMat.TercerParcial;
                query.PrimerRecuperatorio = CursoMat.PrimerRecuperatorio;
                query.SegundoRecuperatorio = CursoMat.SegundoRecuperatorio;
                query.Estado = CursoMat.Estado;
                query.NotaFinal = CursoMat.NotaFinal;
                query.Inscripcion_EFinal = CursoMat.Inscripcion_EFinal;
                bd.SaveChanges();

            }



        }



    }
}
