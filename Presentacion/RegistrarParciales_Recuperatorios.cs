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
    public partial class RegistrarParciales_Recuperatorios : Form
    {
        public RegistrarNotaAluMat reg = new RegistrarNotaAluMat();
        CursoMateria cm = new CursoMateria();
        public RegistrarParciales_Recuperatorios(RegistrarNotaAluMat regNA)
        {
            this.reg = regNA;
             cm = CursoMateriaN.BuscarCursoMateriaxID(Convert.ToInt32(reg.dataGridViewNotas.CurrentRow.Cells[0].Value));
            Console.WriteLine(reg.dataGridViewNotas.CurrentRow.Cells[0].Value);
           
            InitializeComponent();
        }

        private void RegistrarParciales_Recuperatorios_Load(object sender, EventArgs e)
        {
            
            comboBox2Recup.Enabled = false;
            comboBox1Recup.Enabled = false;

            comboBox2P.Enabled = false;
            comboBox3P.Enabled = false;
            
        }



        private bool Validar()
        {
            bool val = false;

            if (string.IsNullOrEmpty(comboBox1P.Text))
            {
                errorProvider1.SetError(comboBox1P,"No puede estar vacío");
            }
            if (string.IsNullOrEmpty(comboBox2P.Text))
            {
                errorProvider1.SetError(comboBox2P, "No puede estar vacío");
            }
            if (string.IsNullOrEmpty(comboBox3P.Text))
            {
                errorProvider1.SetError(comboBox3P, "No puede estar vacío");

            }

            if (!string.IsNullOrEmpty(comboBox1P.Text)&&!string.IsNullOrEmpty(comboBox2P.Text)&&!string.IsNullOrEmpty(comboBox3P.Text))
            {


                errorProvider1.Clear();

                int contDesap = 0;

                int parcial_1 = Convert.ToInt32(comboBox1P.Text);
                int parcial_2 = Convert.ToInt32(comboBox2P.Text);
                int parcial_3 = Convert.ToInt32(comboBox3P.Text);

                int[] arrParciales = { parcial_1, parcial_2, parcial_3 };

                foreach (int i in arrParciales)
                {
                    if (i < 6)
                    {
                        contDesap++;
                    }

                }
               
                    if (contDesap==2)
                {
                    if (string.IsNullOrEmpty(comboBox1Recup.Text)) {

                     errorProvider1.SetError(comboBox1Recup, "No puede estar vacío");
                    }

                    if (string.IsNullOrEmpty(comboBox2Recup.Text))
                    {

                        errorProvider1.SetError(comboBox2Recup, "No puede estar vacío");
                    }

                    if (!string.IsNullOrEmpty(comboBox1Recup.Text) && !string.IsNullOrEmpty(comboBox2Recup.Text))
                    {
                        val = true;
                    }

                }

                if (contDesap == 1)
                {
                    errorProvider1.Clear();

                    if (string.IsNullOrEmpty(comboBox1Recup.Text))
                    {

                        errorProvider1.SetError(comboBox1Recup, "No puede estar vacío");
                    }
                    else
                    {
                        val = true;
                    }
                }

                if (contDesap == 0)
                {
                    val = true;
                }
                if (contDesap == 3)
                {
                    val = true;
                }



            }
            return val;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cm!=null)
            {


                if (Validar() == true)
                {
                    int cont = 0;

                    cm.PrimerParcial = Convert.ToInt32(comboBox1P.Text);
                    cm.SegundoParcial = Convert.ToInt32(comboBox2P.Text);
                    cm.TercerParcial = Convert.ToInt32(comboBox3P.Text);
                    int[] arr = { Convert.ToInt32(comboBox1P.Text), Convert.ToInt32(comboBox2P.Text), Convert.ToInt32(comboBox3P.Text) };

                    foreach (int i in arr)
                    {

                        if (i < 6)
                        {
                            cont++;
                        }


                    }

                    if (cont == 0)
                    {
                        

                        cm.Estado = "Aprobado";
                        cm.NotaFinal = (cm.PrimerParcial + cm.SegundoParcial + cm.TercerParcial)/3;
                    }

                    if (cont == 1)
                    {
                        if (Convert.ToInt32(comboBox1Recup.Text) >=6)
                        {
                            cm.PrimerRecuperatorio = Convert.ToInt32(comboBox1Recup.Text);
                            cm.Estado = "Aprobado";

                            if (cm.PrimerParcial<6)
                            {
                                cm.NotaFinal= ( cm.SegundoParcial + cm.TercerParcial+cm.PrimerRecuperatorio) / 3;
                            }

                            if (cm.SegundoParcial < 6)
                            {
                                cm.NotaFinal = (cm.PrimerParcial + cm.TercerParcial + cm.PrimerRecuperatorio) / 3;
                            }
                            if (cm.TercerParcial < 6)
                            {
                                cm.NotaFinal = (cm.SegundoParcial + cm.PrimerParcial + cm.PrimerRecuperatorio) / 3;
                            }

                        }
                        else
                        {
                            cm.Estado = "Libre";
                        }
                    }

                    if (cont == 2)
                    {
                        if (Convert.ToInt32(comboBox1Recup.Text) >= 6 && Convert.ToInt32(comboBox2Recup.Text) >=6)
                        {
                            cm.PrimerRecuperatorio = Convert.ToInt32(comboBox1Recup.Text);
                            cm.SegundoRecuperatorio = Convert.ToInt32(comboBox2Recup.Text);
                            cm.Estado = "Regular";

                        }
                        else if(Convert.ToInt32(comboBox1Recup.Text) < 6 || Convert.ToInt32(comboBox2Recup.Text) < 6)
                        {
                            cm.Estado = "Libre";
                        }
                    }

                    if (cont == 3)
                    {

                        cm.Estado = "Libre";
                    }








                    if (cm.Estado == "Libre")
                    {

                        if (MessageBox.Show("¿Desea Registrar las Notas?", "Registro de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                        {

                            CursoMateriaN.BajaxIDCurso_Materia(cm.idCursoMateria);
                            MessageBox.Show(string.Format("El Estado del Alumno {0} en la Materia {1} es : {2} ",reg.textBoxAlumno.Text,reg.dataGridViewNotas.CurrentRow.Cells[1].Value.ToString(),cm.Estado), "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            reg.dataGridViewNotas.Rows.Remove(reg.dataGridViewNotas.CurrentRow);

                            this.Close();
                        }


                    }








                  if (cm.Estado == "Regular" )

                    {
                        if (MessageBox.Show("¿Desea Registrar las Notas?", "Registro de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                        {
                            CursoMateriaN.RegistrarNotas(cm);
                            MessageBox.Show(string.Format("El Estado del Alumno {0} en la Materia {1} es : {2} ", reg.textBoxAlumno.Text, reg.dataGridViewNotas.CurrentRow.Cells[1].Value.ToString(), cm.Estado), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reg.dataGridViewNotas.Rows.Remove(reg.dataGridViewNotas.CurrentRow);
                            this.Close();
                        }

                    }












                    if (cm.Estado == "Aprobado")
                    {
                        int contAp = 0;
List<Correlativa> listaCorrelativas= CorrelativaN.ListaCorrelativas(cm.idMateria);

         List<CursoMateria> listaCursoMateria = CursoMateriaN.listaCursoMateriaPorMatricula(cm.Matricula);


                        foreach (Correlativa c in listaCorrelativas)
                        {
                            foreach (CursoMateria cmat in listaCursoMateria)
                            {
                                Materia mat = MateriaN.BuscarMateriaPorID(cmat.idMateria);
                                if (c.Nombre==mat.Nombre)
                                {
                                    if (cmat.Estado=="Aprobado")
                                    {
                                        contAp++;
                                    }
                                }
                            }


                        }

                        if (contAp==listaCorrelativas.Count()) {


                       if (MessageBox.Show("¿Desea Registrar las Notas?", "Registro de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                        {
                            CursoMateriaN.RegistrarNotas(cm);
                            MessageBox.Show(string.Format("El Estado del Alumno {0} en la Materia {1} es : {2} ", reg.textBoxAlumno.Text, reg.dataGridViewNotas.CurrentRow.Cells[1].Value.ToString(), cm.Estado), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reg.dataGridViewNotas.Rows.Remove(reg.dataGridViewNotas.CurrentRow);
                            this.Close();
                        }

                        }
                        else
                        {
                            cm.Estado = "Regular";

                            if (MessageBox.Show("¿Desea Registrar las Notas?", "Registro de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

                            {
                                CursoMateriaN.RegistrarNotas(cm);
                                MessageBox.Show(string.Format("El Estado del Alumno {0} en la Materia {1} es : {2} ", reg.textBoxAlumno.Text, reg.dataGridViewNotas.CurrentRow.Cells[1].Value.ToString(), cm.Estado), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reg.dataGridViewNotas.Rows.Remove(reg.dataGridViewNotas.CurrentRow);
                                this.Close();
                            }

                        }


                        
                    }

                   

                    }








            }
        }

        private void comboBox1P_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2P.Enabled = true;

          
        }

        private void comboBox2P_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox3P.Enabled = true;

           
        }

        private void comboBox3P_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRecup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecup.Checked==true)
            {
                comboBox1Recup.Enabled = true;
                comboBox2Recup.Enabled = true;

            }
            else
            {
                comboBox1Recup.Enabled = false;
                comboBox2Recup.Enabled = false;
                comboBox1Recup.SelectedIndex = -1;
                comboBox2Recup.SelectedIndex=-1;
                errorProvider1.Clear();
            }
        }
    }
}
