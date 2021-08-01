using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
   public  class CursoMateriaN
    {

        public static void AltaCursoMateria(CursoMateria CursoMateria)
        {
            CursoMateriaDato.AltaCursoMateria(CursoMateria);
        }


            public static void BajaIdMateria(int idMateria)
        {
            CursoMateriaDato.BajaIdMateria(idMateria);
        }

        public static List<CursoMateria> listaCursoMateria(int idDivision, int idMateria, string estado)
        {
            return CursoMateriaDato.listaCursoMateria( idDivision,  idMateria,  estado);
        }


        public static List<CursoMateria> listaCursoMateria(int idMateria)
        {
            return CursoMateriaDato.listaCursoMateria(idMateria);

        }







            public static List<CursoMateria> listaCursoMateriaPorMatricula(int matricula)
        {
            return CursoMateriaDato.listaCursoMateriaPorMatricula(matricula);
        }

        public static CursoMateria BuscarCursoMateriaxID(int idCursoMateria)
        {

            CursoMateria cm  = CursoMateriaDato.BuscarCursoMateriaxID(idCursoMateria);
            if (cm!=null)
            {
                return cm;
            }
            else
            {
                return null;
            }

        }

        public static void BajaxIDCurso_Materia(int idCursoMateria)
        {
            if (BuscarCursoMateriaxID(idCursoMateria)!=null)
            {
                 CursoMateriaDato.BajaxIDCurso_Materia(idCursoMateria);
            }

            
        }


        public static List<CursoMateria> listaCursoMateriaPorIDMateria(int idMateria,string estado)
        {
            List<CursoMateria> listaCursoMateria = CursoMateriaDato.listaCursoMateriaPorIDMateria(idMateria,estado);

            if (listaCursoMateria.Count()==0)
            {
                return null;
            }
            else
            {

                return listaCursoMateria;
            }

        }



        public static CursoMateria listaCursoMateria_Matricula_Materia(int matricula, int idMateria)
        {

            return CursoMateriaDato.listaCursoMateria_Matricula_Materia(matricula, idMateria);



        }



            public static List<CursoMateria> listaCursoMateria_Matricula_Estado(int matricula, string estado)
        {

            List<CursoMateria> listaCursoMateria = CursoMateriaDato.listaCursoMateria_Matricula_Estado(matricula, estado);


            if (listaCursoMateria.Count() == 0)
            {
                return null;
            }
            else
            {

                return listaCursoMateria;
            }

        }


        public static void RegistrarNotas(CursoMateria CursoMat)
        {
            CursoMateriaDato.RegistrarNotas(CursoMat);
            
        }

        }
}
