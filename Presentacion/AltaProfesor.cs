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
    public partial class AltaProfesor : Form
    {
        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar()==true)
            {

  if (MessageBox.Show("¿ Desea registrar al nuevo docente ?","Alta Profesor",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

                Profesor profesor = new Profesor();
                profesor.NombreYApellido = textBoxNombreApellido.Text;
                profesor.Direccion = textBoxDireccion.Text;
                profesor.Telefono = textBoxTelefono.Text;
                profesor.DNI = textBoxDNI.Text;
                
                ProfesorN.AltaProfesores(profesor);

                MessageBox.Show("Se ha registrado el nuevo profesor", "Alta Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
               

            }
          




        }


        private bool Validar()
        {
            bool validar = false;
            if (string.IsNullOrEmpty(textBoxNombreApellido.Text))
            {

                errorProvider1.SetError(textBoxNombreApellido,"No puede estar vacío");

            }
            else { errorProvider1.Clear(); }
            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {

                errorProvider1.SetError(textBoxDNI, "No puede estar vacío");

            }
            else { errorProvider1.Clear(); }


            if (string.IsNullOrEmpty(textBoxDireccion.Text))
            {
                errorProvider1.SetError(textBoxDireccion, "No puede estar vacío");


            }
            else { errorProvider1.Clear(); }
            if (string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                errorProvider1.SetError(textBoxTelefono, "No puede estar vacío");


            }
            else { errorProvider1.Clear(); }
            if (!string.IsNullOrEmpty(textBoxTelefono.Text)&& !string.IsNullOrEmpty(textBoxDireccion.Text) && !string.IsNullOrEmpty(textBoxDNI.Text) && !string.IsNullOrEmpty(textBoxNombreApellido.Text))
            {

                errorProvider1.Clear();
                validar = true;
            }

            return validar;

        }

        private void AltaProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
