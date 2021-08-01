using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class CorrelativaN
    {


        public static void AltaCorrelativa(Correlativa nuevaMateria)
        {

            CorrelativaDato.AltaCorrelativa(nuevaMateria);


        }

        public static void BajaCorrelativa(Correlativa matBaja)
        {

            CorrelativaDato.BajaCorrelativa(matBaja);


        }

        public static void BajaxIDMateria(int idMateria)
        {

            CorrelativaDato.EliminarxIDMateria(idMateria);


        }


        public static void BajaxNombreCorrelativa(string nombre)
        {

            CorrelativaDato.EliminarxNombreCorrelativa(nombre);


        }

        public static void BajaPorIDCorrelativa(int idCorrelativa)
        {
            CorrelativaDato.BajaPorIDCorrelativa(idCorrelativa);
        }

            public static List<Correlativa> ListaCorrelativas(int idMateria)
        {
            return CorrelativaDato.ListaCorrelativas(idMateria);

        }


       

            public static void ModificarCorrelativa(Correlativa correlativa)
        {
            CorrelativaDato.ModificarCorrelativa(correlativa);

        }
    }
}