using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
namespace Presentacion
{
    public partial class FrmBajaMateria : Form
    {

        List<Materia> listaMat = new List<Materia>();

        public FrmBajaMateria()
        {
            listaMat = MateriaN.CargarMaterias();
            InitializeComponent();
        }


        private void FrmBajaMateria_Load(object sender, EventArgs e)
        {
            dataGridViewMat.AutoGenerateColumns = false;

            CargarDGV(MateriaN.BuscarMateriaxNombre(textNombreBuscar.Text));

        }






        internal void CargarDGV(List<Materia> listamateria)
        {


            foreach (Materia m in listamateria)
            {

                dataGridViewMat.Rows.Add(m.idMateria, m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, "Eliminar", "Modificar");

            }





        }

        private void textNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNombreBuscar.Text))

            {
                dataGridViewMat.Rows.Clear();
                CargarDGV(listaMat);
            }
            else
            {
                dataGridViewMat.Rows.Clear();
                CargarDGV(MateriaN.BuscarMateriaxNombre(textNombreBuscar.Text));

            }




        }

        private void dataGridViewMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            /*if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)*/

            if((e.ColumnIndex == dataGridViewMat.Columns["Eliminar"].Index))
            {


                if (MessageBox.Show("Desea eliminar la Materia seleccionada?", "Eliminar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //Todo el codigo de Eliminacion
                    int idMateria = Convert.ToInt32(dataGridViewMat.CurrentRow.Cells[0].Value);
                    string nombre = dataGridViewMat.CurrentRow.Cells[1].Value.ToString();
                    CorrelativaN.BajaxIDMateria(idMateria);
                    CorrelativaN.BajaxNombreCorrelativa(nombre);
                    CursoMateriaN.BajaIdMateria(idMateria);
                    MateriaN.BajaMateriaxID(idMateria);
                    
                    dataGridViewMat.Rows.Clear();
                    CargarDGV(MateriaN.CargarMaterias());

                    MessageBox.Show("La Materia fue eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }




            }

            if (e.ColumnIndex == dataGridViewMat.Columns["Modificar"].Index)
            {
                FrmModificarMateria frmModificar = new FrmModificarMateria(this);
                frmModificar.textIDMateria.Text = dataGridViewMat.CurrentRow.Cells[0].Value.ToString();
                frmModificar.textNombreMateria.Text = dataGridViewMat.CurrentRow.Cells[1].Value.ToString();
                frmModificar.textProfesor.Text = dataGridViewMat.CurrentRow.Cells[2].Value.ToString();

               


                frmModificar.ShowDialog();

            }
        }
    }
}
