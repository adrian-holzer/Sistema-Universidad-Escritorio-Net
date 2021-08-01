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
    public partial class Registrar_Final_Materias_AlumnosInsc_Nota : Form
    {



        // Paso el formulario anterior para que pueda ser modificado y poder acceder a los atributos
        Registrar_Final_Materias_AlumnosInsc reg;
        Alumno al;
        public Registrar_Final_Materias_AlumnosInsc_Nota(Registrar_Final_Materias_AlumnosInsc  reg)
        {
            this.reg = reg;
             al = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(reg.dataGridViewAlumnosFinal.CurrentRow.Cells[0].Value)).ElementAt(0);

            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Final_Materias_AlumnosInsc_Nota_Load(object sender, EventArgs e)
        {


            btnRegistrar.Enabled = false;


            // Busco el alumno a partir de la matricula registrada en el datagrid del formulario anterior
            Alumno al = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(reg.dataGridViewAlumnosFinal.CurrentRow.Cells[0].Value)).ElementAt(0);


            textBoxMatricula.Enabled = false;
            textBoxAlumno.Enabled = false;
            textBoxMatricula.Text = al.Matricula.ToString();
            textBoxAlumno.Text = al.NombreYApellido;





        }

        private void comboBoxNota_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comboBoxNota.Text))
            {
                btnRegistrar.Enabled = false;

            }
            else
            {
                btnRegistrar.Enabled = true;

            }


            if (comboBoxNota.Text=="Ausente")
            {
                textBoxEstado.Text = "Ausente";
            }
           else if (Convert.ToInt32(comboBoxNota.Text) < 6)
            {
                textBoxEstado.Text = "Desaprobado";
            }
           else if (Convert.ToInt32(comboBoxNota.Text) >= 6)
            {
                textBoxEstado.Text = "Aprobado";
            }


            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Actualizo el datagrid segun lo que ingrese en el formulario

            if (MessageBox.Show("¿Desea registrar la Nota Final  ? ","Registrar Final",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

                reg.dataGridViewAlumnosFinal.CurrentRow.SetValues(al.Matricula,al.NombreYApellido,textBoxEstado.Text,comboBoxNota.Text,"Registrar");


                this.Close();
            }




        }
    }
}
