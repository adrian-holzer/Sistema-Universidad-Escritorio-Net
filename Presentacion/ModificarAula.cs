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
    public partial class ModificarAula : Form
    {
        Aula aula;
        
        public ModificarAula(Aula aula)
        {
            this.aula = aula;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            
                bool validar = false;
                if (string.IsNullOrEmpty(textBoxNombreAula.Text))
                {

                    errorProvider1.SetError(textBoxNombreAula, "No puede estar vacío");

                }
                else { errorProvider1.Clear(); }
                if (string.IsNullOrEmpty(comboBoxConexion.Text))
                {

                    errorProvider1.SetError(comboBoxConexion, "No puede estar vacío");

                }
                else { errorProvider1.Clear(); }


                if (string.IsNullOrEmpty(textBoxCapacidad.Text))
                {
                    errorProvider1.SetError(textBoxCapacidad, "No puede estar vacío");


                }
                else { errorProvider1.Clear(); }
                if (string.IsNullOrEmpty(comboBoxProyector.Text))
                {
                    errorProvider1.SetError(comboBoxProyector, "No puede estar vacío");


                }
                else { errorProvider1.Clear(); }
                if (!string.IsNullOrEmpty(textBoxNombreAula.Text) && !string.IsNullOrEmpty(comboBoxConexion.Text) && !string.IsNullOrEmpty(textBoxCapacidad.Text) && !string.IsNullOrEmpty(comboBoxProyector.Text))
                {

                    errorProvider1.Clear();
                    validar = true;
                }

                return validar;
            }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (Validar()==true)
            {
                


           if (MessageBox.Show("¿ Desea modificar los datos del Aula ?", "Modificar Aula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Modificar();





                    MessageBox.Show("Se ha modificado el Aula", "Modificar Aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }



                

               

            }
        }


        private void LLenarDatos()
        {
            textBoxNombreAula.Text = aula.NombreAula;
            
            textBoxCapacidad.Text = aula.Capacidad.ToString();
            



        }

        private void Modificar()
        {
            // instrucciones para modificar

            aula.NombreAula = textBoxNombreAula.Text;
            aula.Capacidad = Convert.ToInt32(textBoxCapacidad.Text);
            aula.Proyector = Convert.ToBoolean(comboBoxProyector.SelectedValue);
           aula.ConexionRed = Convert.ToBoolean(comboBoxProyector.SelectedValue);

            AulaN.ModificarAula(aula);



        }

        private void ModificarAula_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }
    }
}
