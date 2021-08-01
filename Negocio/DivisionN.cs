using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
   public class DivisionN
    {


        public static List<Division> ListarDivisiones(Curso curso)
        {
           
            return DivisionDato.ListarDivisiones(curso);
        }



        public static Division BuscarDivisionporID(int idDivision)
        {

            return DivisionDato.BuscarDivisionporID(idDivision);

        }

        public static void ModificarDivision(Division division)
        {

            DivisionDato.ModificarDivision(division);

           }
        }
    }
