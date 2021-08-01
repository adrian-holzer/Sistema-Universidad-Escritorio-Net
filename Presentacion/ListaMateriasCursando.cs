using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
namespace Presentacion
{
    public partial class ListaMateriasCursando : Form
    {
        Alumno alumno = new Alumno();
        List<CursoMateria> listCursoMateria = new List<CursoMateria>();


        public ListaMateriasCursando(Alumno al)
        {

            this.alumno = al;
             listCursoMateria = CursoMateriaN.listaCursoMateriaPorMatricula(alumno.Matricula);

            InitializeComponent();
        }

        private void ListaMateriasCursando_Load(object sender, EventArgs e)
        {
          
            CargarDGV();




        }


        private void CargarDGV()
        {
           
            List<CursoMateria> listCursoMateriaCursando = new List<CursoMateria>();
            foreach (CursoMateria cm in listCursoMateria)
            {

                if (cm.Estado=="Cursando")
                {

                    listCursoMateriaCursando.Add(cm);

                }

            }


            foreach (CursoMateria cm in listCursoMateriaCursando)
            {

                Materia m = MateriaN.BuscarMateriaPorID(cm.idMateria);
                Division d = DivisionN.BuscarDivisionporID(Convert.ToInt32(cm.idDivision));
                Curso c = CursoN.BuscaCursoPorID(d.idDivision);


            dataGridViewCursadas.Rows.Add(m.Nombre,ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido,c.Nombre,d.NombreDivision,AulaN.BuscarAula(c.idAula).NombreAula);

            }
           


        }
    }
}
