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
    public partial class ModificarProfesor : Form
    {
        Profesor p;
        public ModificarProfesor(Profesor p )
        {
            this.p = p;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LLenarDatos()
        {
            textBox1.Text = p.Legajo.ToString();
            textBoxNombreApellido.Text = p.NombreYApellido;
            textBoxTelefono.Text = p.Telefono;
            textBoxDNI.Text = p.DNI;
            textBoxDireccion.Text = p.Direccion;




        }

        private void Modificar()
        {
            // instrucciones para modificar

            p.NombreYApellido = textBoxNombreApellido.Text;
             p.Telefono = textBoxTelefono.Text ;
            p.DNI= textBoxDNI.Text ;
            p.Direccion= textBoxDireccion.Text ;

            ProfesorN.ModificarProfesor(p);



        }


        private void ModificarProfesor_Load(object sender, EventArgs e)
        {
            LLenarDatos(); // lleno los textbox con los datos del docente que se va a modificar
        }


        // valido que los textbox no esten vacios 
        private bool Validar()
        {
            bool validar = false;
            if (string.IsNullOrEmpty(textBoxNombreApellido.Text))
            {

                errorProvider1.SetError(textBoxNombreApellido, "No puede estar vacío");

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
            if (!string.IsNullOrEmpty(textBoxTelefono.Text) && !string.IsNullOrEmpty(textBoxDireccion.Text) && !string.IsNullOrEmpty(textBoxDNI.Text) && !string.IsNullOrEmpty(textBoxNombreApellido.Text))
            {

                errorProvider1.Clear();
                validar = true;
            }

            return validar;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar()==true)
            {
                if (MessageBox.Show("¿ Desea modificar los datos ?", "Modificar Profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Modificar();

                    MessageBox.Show(string.Format("Se han modificado los datos del docente {0}",p.NombreYApellido), "Modificar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
