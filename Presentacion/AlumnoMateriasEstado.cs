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
    public partial class AlumnoMateriasEstado : Form
    {
        public List<Alumno> listaAlumnos = new List<Alumno>();
        public AlumnoMateriasEstado()
        {
            InitializeComponent();
        }




        private void CargarDGV(List<Alumno> listaAlumnos)
        {
            foreach (Alumno a in listaAlumnos)
            {

                dataGridViewAlumnos.Rows.Add(a.Matricula, a.NombreYApellido, "Materias Cursadas", "Materias Regulares","Materias Aprobadas");

            }



        }

        private void Refrescar()
        {
            dataGridViewAlumnos.Rows.Clear();
            CargarDGV(AlumnoN.CargarAlumnos());
        }
        private void AlumnoMateriasEstado_Load(object sender, EventArgs e)
        {

            textBoxNo.Visible = false;
            if (AlumnoN.CargarAlumnos() != null)
            {
                listaAlumnos = AlumnoN.CargarAlumnos();
            }
            else
            {

                textBoxNo.Visible = true;
            }

            dataGridViewAlumnos.AutoGenerateColumns = false;
            CargarDGV(listaAlumnos);

        }

        private void textBoxMatriculaBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMatriculaBuscar.Text))

            {
                dataGridViewAlumnos.Rows.Clear();
                CargarDGV(listaAlumnos);
            }
            else
            {
                try
                {
                    dataGridViewAlumnos.Rows.Clear();

                    CargarDGV(AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(textBoxMatriculaBuscar.Text)));
                }
                catch (Exception ex) { }
                }
            }
        

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Alumno al = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells[0].Value)).ElementAt(0);



            if ((e.ColumnIndex == dataGridViewAlumnos.Columns["Cursando"].Index))
            {

                
                ListaMateriasCursando listaCursando = new ListaMateriasCursando(al);
                listaCursando.Show();




            }

            if ((e.ColumnIndex == dataGridViewAlumnos.Columns["Regulares"].Index))
            {


                ListaMateriasRegulares listaMateriasRegulares = new ListaMateriasRegulares(al);

                listaMateriasRegulares.ShowDialog();

            }







            if ((e.ColumnIndex == dataGridViewAlumnos.Columns["Aprobadas"].Index))
            {


                ListaMateriasAprobadas listaMateriasAprobadas = new ListaMateriasAprobadas(al);
                listaMateriasAprobadas.ShowDialog();



            }










        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
