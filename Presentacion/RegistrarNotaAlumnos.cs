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
    public partial class RegistrarNotaAlumnos : Form
    {

        public List<Alumno> listaAlumnos = new List<Alumno>();
        public RegistrarNotaAlumnos()
        {
            InitializeComponent();
        }

        private void RegistrarNotaAlumnos_Load(object sender, EventArgs e)
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

        private void textBoxBuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBuscarAlumno.Text))

            {
                dataGridViewAlumnos.Rows.Clear();
                CargarDGV(listaAlumnos);
            }
            else
            {
                dataGridViewAlumnos.Rows.Clear();
                CargarDGV(AlumnoN.BuscarAlumnoxNombre(textBoxBuscarAlumno.Text));

            }

        }

        private void CargarDGV(List<Alumno> listaAlumnos)
        {
            foreach (Alumno a in listaAlumnos)
            {

                dataGridViewAlumnos.Rows.Add(a.Matricula, a.NombreYApellido, "Seleccionar");

            }



        }

        private void Refrescar()
        {
            dataGridViewAlumnos.Rows.Clear();
            CargarDGV(listaAlumnos);
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dataGridViewAlumnos.Columns["Seleccionar"].Index))
            {





                RegistrarNotaAluMat reg = new RegistrarNotaAluMat(this);
                reg.Show();



               



            }
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
    }
}
