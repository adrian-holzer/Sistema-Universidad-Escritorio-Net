using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class MateriaN
    {


        public static bool AltaMateria(Materia nuevaMateria)
        {
            if (MateriaDato.Existe(nuevaMateria.Nombre) == false)
            {

                MateriaDato.AltaMateria(nuevaMateria);
                return true;
            }
            else


                return false;

        }


        public bool BajaMateria(Materia materiaEliminar)
        {
            if (MateriaDato.Existe(materiaEliminar.Nombre) == true)
            {

                MateriaDato.AltaMateria(materiaEliminar);
                return true;
            }
            else


                return false;

        }

        public static void BajaMateriaxID(int idMateria)
        {

            MateriaDato.BajaMateriaxID(idMateria);
        }





        public static List<Materia> CargarMaterias()
        {

            return MateriaDato.CargarMaterias();


        }




        public static List<Materia> BuscarMateriaxNombre(string nomb)
        {

            return MateriaDato.BuscarMateriaxNombre(nomb);
        }

        public static void ModificarMateria(Materia materia)
        {


            MateriaDato.ModificarMateria(materia);





        }


        public static Materia BuscarMateriaPorID(int idMateria)
        {
            Materia mat = MateriaDato.BuscarMateriaPorID(idMateria);
            if (mat != null)
            {
                return mat;
            }
            else return null;

        }


       
    }
}
