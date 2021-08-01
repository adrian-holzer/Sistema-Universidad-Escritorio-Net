using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class CursoN
    {


        public static List<Curso> ListarCursosPorNombre()
        {

            return CursoDato.ListarCursosPorNombre();

        }

        public static Curso BuscaCursoPorID(int idCurso)
        {

            return CursoDato.BuscaCursoPorID(idCurso);
        }

        public static Curso BuscaCursoPorNombre(string nombreCurso)
        {

            return CursoDato.BuscaCursoPorNombre(nombreCurso);

        }

        public static Curso BuscaCursoPorAula(int idAula)
        {

            Curso c = CursoDato.BuscaCursoPorID(idAula);
            if (c != null)
            {
                return c;

            }
            else return null;
        }



            public static List<Materia> ListarMateriasPorCurso(Curso curso)
        {
            return CursoDato.ListarMateriasPorCurso(curso);
        }
    }
}
