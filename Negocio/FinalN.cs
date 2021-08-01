using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;
namespace Negocio
{
    public class FinalN
    {





        public static void AltFinal(Final final)
        {



            FinalDato.AltFinal(final);

        }



        public static Final BuscarFinal(int idCursoMateria)
        {
            Final final = FinalDato.BuscarFinal(idCursoMateria);

            if (final != null)
            {
                return final;
            }
            else return null;
        }



        public static void ActualizarFinal(Final final)
        {

            FinalDato.ActualizarFinal(final);
        }

        public static void BajaFinales(int idCursoMateria)
        {

            FinalDato.BajaFinales(idCursoMateria);
        }




            public static List<Final> ListarFinales(int idCursoMateria)
        {
            return FinalDato.ListarFinales(idCursoMateria);
        }
        }
    }
