using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
   public class ProfesorN
    {
        public static void AltaProfesores(Profesor profesor)
        {

            ProfesorDato.AltaProfesores(profesor);
        }


        public static void BajaProfesores(Profesor profesor)
        {
            ProfesorDato.BajaProfesores(profesor);

        }




            public static List<Profesor> CargarProfesores()
        {
            
                return ProfesorDato.CargarProfesores();
            

        }

        public static Profesor BuscarxLegajo(int legajo)
        {

            return ProfesorDato.BuscarxLegajo(legajo);


        }

        public static List<Profesor> BuscarProfesorxNombre(string nomb)
        {

            return ProfesorDato.BuscarProfesorxNombre(nomb);

        }



        public static List<Materia> MateriasDictadas(int legajo)
        {
            List<Materia> listaMatDictadas = ProfesorDato.MateriasDictadas(legajo);

            if (listaMatDictadas.Count>0)
            {
                return listaMatDictadas;
            }
            else
            {
                return null;
            }
        }







        public static void ModificarProfesor(Profesor profesor)
        {

            ProfesorDato.ModificarProfesor(profesor);
        }
        }
}
