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
    public partial class Inscribir_Final_Alumnos : Form
    {
        public List<Alumno> listaAlumnos = new List<Alumno>();

        public Inscribir_Final_Alumnos()
        {
            InitializeComponent();
        }

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMatricula.Text))

            {
                dataGridViewAlumnos.Rows.Clear();
                CargarDGV(listaAlumnos);
            }
            else
            {
                try
                {
                    dataGridViewAlumnos.Rows.Clear();
                    CargarDGV(AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(textBoxMatricula.Text)));

                }
                catch (Exception ex) { }


            }
        }


        private void CargarDGV(List<Alumno> listaAlumnos)
        {
            foreach (Alumno a in listaAlumnos)
            {

                dataGridViewAlumnos.Rows.Add(a.Matricula, a.NombreYApellido);

            }



        }

        private void Inscribir_Final_Alumnos_Load(object sender, EventArgs e)
        {
            listaAlumnos = AlumnoN.CargarAlumnos();
            CargarDGV(listaAlumnos);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Alumno alumno = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells[0].Value)).ElementAt(0);

            Inscribir_Final_Alumno_Materia ins = new Inscribir_Final_Alumno_Materia( alumno);

            ins.Show();

        }
    }
}
