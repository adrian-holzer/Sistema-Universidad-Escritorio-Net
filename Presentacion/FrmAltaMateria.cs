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
    public partial class FrmAltaMateria : Form
    {
        List<Correlativa> listaCorr = new List<Correlativa>();

        bool validar = false;
        public FrmAltaMateria()
        {
            InitializeComponent();
        }

        private void FrmAltaMateria_Load(object sender, EventArgs e)
        {

            CargarCxProfesores();
            CargarCxMaterias();
            CargarCxCurso();

            comboBxCorrelativa.SelectedIndex = -1;
            comboBoxProfesor.SelectedIndex = -1;
            comboBxRequisito.SelectedIndex = -1;
            comboBoxCurso.SelectedIndex = -1;

            comboBxCorrelativa.Enabled = false;
            comboBxRequisito.Enabled = false;
            btnRCorr.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿Desea Guardar los datos?", "Alta Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {








                Materia nueva = new Materia();
                nueva.Nombre = textNombreMateria.Text;
                nueva.Legajo = Convert.ToInt32(comboBoxProfesor.SelectedValue);
                nueva.IdCurso = Convert.ToInt32(comboBoxCurso.SelectedValue);

                validar = ValidarAlta();

                if (validar == true)
                {





                    if (MateriaN.AltaMateria(nueva) == false)
                    {
                        MessageBox.Show("La Materia Ingresada ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {





                        MateriaN.AltaMateria(nueva);

                        // Asigno correlativa

                        foreach (DataGridViewRow dr in dataGridView1.Rows)
                        {


                            Correlativa nCorr = new Correlativa();

                            nCorr.idMateria = nueva.idMateria;
                            nCorr.Nombre = dr.Cells[0].Value.ToString();
                            nCorr.Requisito = dr.Cells[1].Value.ToString();

                            CorrelativaN.AltaCorrelativa(nCorr);

                        }



                        MessageBox.Show("La Materia fue registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }




        }


        public void CargarCxProfesores()
        {
            comboBoxProfesor.DataSource = ProfesorN.CargarProfesores();
            comboBoxProfesor.ValueMember = "Legajo";
            comboBoxProfesor.DisplayMember = "NombreYApellido";

        }

        public void CargarCxMaterias()
        {

            comboBxCorrelativa.DataSource = MateriaN.CargarMaterias();
            comboBxCorrelativa.ValueMember = "idMateria";
            comboBxCorrelativa.DisplayMember = "Nombre";

        }



        public void CargarCxCurso()
        {

            comboBoxCurso.DataSource = CursoN.ListarCursosPorNombre();
            comboBoxCurso.ValueMember = "idCurso";
            comboBoxCurso.DisplayMember = "Nombre";

        }







        public bool ValidarAlta()
        {
            bool validar = false;

            if (ValidarMateria() == true)
            {
                if (chkboxSi.Checked == true)
                {

                    if (ValidarCorrelativa() == true)
                    {
                        validar = true;
                        errorProvider1.Clear();
                    }

                }
                else
                {
                    validar = true;
                    errorProvider1.Clear();
                }


            }
            return validar;

        }

        private void chkboxCorr_Click(object sender, EventArgs e)
        {

        }

        private void chkboxCorr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSi.Checked == true)
            {
                comboBxRequisito.Enabled = true;
                comboBxCorrelativa.Enabled = true;
                btnRCorr.Enabled = true;
                textNombreMateria.Enabled = false;

                comboBoxCurso.Enabled = false;
            }
            else
            {
                comboBxRequisito.Enabled = false;
                comboBxCorrelativa.Enabled = false;
                btnRCorr.Enabled = false;
                textNombreMateria.Enabled = true;

                comboBoxCurso.Enabled = true;
                dataGridView1.Rows.Clear();
                errorProvider1.Clear();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRCorr_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if (ValidarAlta() == true)
            {

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {

                    if (dr.Cells[0].Value.ToString().Equals(comboBxCorrelativa.Text))
                    {
                        existe = true;
                    }


                }

                if (existe == false)
                {

                    // verifico que la correlativa no sea de un año superior




                    Materia mat = MateriaN.BuscarMateriaxNombre(comboBxCorrelativa.Text).ElementAt(0);
                    Curso c = CursoN.BuscaCursoPorID(mat.IdCurso);

                    if (Convert.ToInt32(c.Nombre) > Convert.ToInt32(comboBoxCurso.Text))
                    {

                        MessageBox.Show("No puede tener como correlativa materias de años superiores", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {

                        dataGridView1.Rows.Add(comboBxCorrelativa.Text, comboBxRequisito.Text);
                    }





                }
                else
                {
                    MessageBox.Show("La Correlativa seleccionada ya se encuentra en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    existe = false;
                }



            }
            else
            {
                if (string.IsNullOrEmpty(comboBxCorrelativa.Text))
                {
                    errorProvider1.SetError(comboBxCorrelativa, "No puede estar vacio");
                }
                if (string.IsNullOrEmpty(comboBxRequisito.Text))
                {
                    errorProvider1.SetError(comboBxRequisito, "No puede estar vacio");
                }

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar la Correlativa Seleccionada", "Eliminar Correlativa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
        }



        public bool ValidarMateria()
        {

            bool validar = false;

            if (string.IsNullOrEmpty(textNombreMateria.Text))
            {
                errorProvider1.SetError(textNombreMateria, "No puede estar vacio");
            }
            if (string.IsNullOrEmpty(comboBoxCurso.Text))
            {
                errorProvider1.SetError(comboBoxCurso, "No puede estar vacio");
            }
            if (string.IsNullOrEmpty(comboBoxProfesor.Text))
            {
                errorProvider1.SetError(comboBoxProfesor, "No puede estar vacio");
            }

            if (!string.IsNullOrEmpty(textNombreMateria.Text) && !string.IsNullOrEmpty(comboBoxCurso.Text) && !string.IsNullOrEmpty(comboBoxProfesor.Text))
            {
                validar = true;
            }
            return validar;

        }

        public bool ValidarCorrelativa()
        {

            if (string.IsNullOrEmpty(comboBxCorrelativa.Text))
            {
                errorProvider1.SetError(comboBxCorrelativa, "No puede estar vacio");
            }
            if (string.IsNullOrEmpty(comboBxRequisito.Text))
            {
                errorProvider1.SetError(comboBxRequisito, "No puede estar vacio");
            }

            if (!string.IsNullOrEmpty(comboBxCorrelativa.Text) && !string.IsNullOrEmpty(comboBxRequisito.Text))
            {
                validar = true;
            }
            return validar;

        }
    }
}
