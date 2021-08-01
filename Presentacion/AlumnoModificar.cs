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
    public partial class AlumnoModificar : Form
    {
        Alumno alumno= new Alumno();
        public AlumnoModificar(Alumno al)
        {
            this.alumno = al;
            InitializeComponent();
        }

        private void AlumnoModificar_Load(object sender, EventArgs e)
        {

           textBoxMatricula.Text = alumno.Matricula.ToString();
           
           textBoxNombApe.Text = alumno.NombreYApellido;
           textBoxDireccion.Text = alumno.Direccion;
           textBoxTelefono.Text = alumno.Telefono;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Modificar los datos ?", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                alumno.NombreYApellido = textBoxNombApe.Text;
                alumno.Direccion = textBoxDireccion.Text;
                alumno.Telefono = textBoxTelefono.Text;

                AlumnoN.ModificarAlumno(alumno);
            }
            this.Close();
        }
    }
}
