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
    public partial class Registrar_Final_Materias : Form
    {
        List<Materia> listaMaterias = new List<Materia>();
        public Registrar_Final_Materias()
        {
            InitializeComponent();
        }

        private void Registrar_Nota_Final_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }



        private void CargarDGV() {


            List<Curso> listaCurso = CursoN.ListarCursosPorNombre();

            foreach (Curso c in listaCurso){

                listaMaterias = CursoN.ListarMateriasPorCurso(c);

                foreach (Materia m in listaMaterias){

                    dataGridViewMaterias.Rows.Add(m.idMateria,m.Nombre,ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido,c.Nombre,"Seleccionar");

                   }

            }




        }

        private void Refrescar(){

            dataGridViewMaterias.Rows.Clear();
            CargarDGV();


        }

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.ColumnIndex == dataGridViewMaterias.Columns["Seleccionar"].Index)){

                Materia materia = MateriaN.BuscarMateriaPorID(Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value));
                Registrar_Final_Materias_AlumnosInsc r = new Registrar_Final_Materias_AlumnosInsc(materia);
                r.Show();



            }






        }
    }
}
