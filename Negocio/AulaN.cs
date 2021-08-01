using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
  public  class AulaN
    {




        public static Aula BuscarAula(int idAula)

        {
            return AulaDato.BuscarAula(idAula);
        }

        public static List<Aula> ListarAulas()
        {
            return AulaDato.ListarAulas();
        }



        public static void ModificarAula(Aula aula)
        {

            AulaDato.ModificarAula(aula);
        }

        }
}
