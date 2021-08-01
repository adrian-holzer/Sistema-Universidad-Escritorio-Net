using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
namespace Presentacion
{
    public partial class FrmModificarMateria : Form
    {

        FrmBajaMateria frmbaja = new FrmBajaMateria();
        Materia mat = new Materia();
        public FrmModificarMateria(FrmBajaMateria frmbaja)
        {
            this.frmbaja = frmbaja;
            
            InitializeComponent();
        }

        public FrmModificarMateria()
        {
            

            InitializeComponent();
        }

        List<Correlativa> listacorr = new List<Correlativa>();

        private void FrmModificarMateria_Load(object sender, EventArgs e)
        {

            mat = MateriaN.BuscarMateriaPorID(Convert.ToInt32(frmbaja.dataGridViewMat.CurrentRow.Cells[0].Value));

            dataGridViewCorr.AutoGenerateColumns = false;
           
            
            textProfesor.Text = ProfesorN.BuscarxLegajo(mat.Legajo).NombreYApellido;

            listacorr = CorrelativaN.ListaCorrelativas(Convert.ToInt32(textIDMateria.Text));
            CargarDGV(listacorr);


            CargarCxProfesores();
            comboBoxProfesor.SelectedValue = ProfesorN.BuscarxLegajo(mat.Legajo).Legajo;
          comboBoxProfesor.SelectedIndex = -1;
            
        }




        private void CargarDGV(List<Correlativa> listacorrelativa)
        {

            foreach (Correlativa c in listacorrelativa)
            {

                dataGridViewCorr.Rows.Add(c.idCorrelativa,c.Nombre, c.Requisito,"Editar");

            }




        }


        public void CargarCxProfesores()
        {
            comboBoxProfesor.DataSource = ProfesorN.CargarProfesores();
            comboBoxProfesor.ValueMember = "Legajo";
            comboBoxProfesor.DisplayMember = "NombreYApellido";

        }

        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProfesor.SelectedIndex == -1) {
                textProfesor.Text = ProfesorN.BuscarxLegajo(mat.Legajo).NombreYApellido;
            }
            else {  textProfesor.Text = comboBoxProfesor.Text;}
           
           
        }

        private void dataGridViewCorr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dataGridViewCorr.Columns["Editar"].Index))
            {

                FrmModifCorr f = new FrmModifCorr(this);
                f.ShowDialog();

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            //Modifico la materia 
            


            if (Validar()==true && ValidarDatos()==true) {

                if (MessageBox.Show("Desea Modificar la Materia ?", "Modificar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Materia matModif = new Materia();
                    matModif.idMateria = Convert.ToInt32(textIDMateria.Text);
                    matModif.Nombre = textNombreMateria.Text;

                    if (string.IsNullOrEmpty(comboBoxProfesor.Text))
                    {

                        matModif.Legajo = mat.Legajo;
                    }
                    else
                    {
                        matModif.Legajo = Convert.ToInt32(comboBoxProfesor.SelectedValue);
                    }
                   


                    MateriaN.ModificarMateria(matModif);

                    
                    foreach (DataGridViewRow dr  in dataGridViewCorr.Rows)
                    {
                        Correlativa c = new Correlativa();
                        c.idCorrelativa = Convert.ToInt32(dr.Cells[0].Value);
                        c.Requisito = dr.Cells[2].Value.ToString();
                        CorrelativaN.ModificarCorrelativa(c);

                    }
                    

                        MessageBox.Show(string.Format("La Materia {0} se ha modificado existosamente", matModif.Nombre), "Modificacion de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                   
                    frmbaja.dataGridViewMat.Rows.Clear();
                    frmbaja.CargarDGV(MateriaN.CargarMaterias());
                }
                }
            }

        


        private bool Validar()
        {
            bool validar = false;
            if (string.IsNullOrEmpty(textNombreMateria.Text))
            {

                errorProvider1.SetError(textNombreMateria, "No puede estar vacio");

            }
            if (string.IsNullOrEmpty(textProfesor.Text))
            {

                errorProvider1.SetError(textProfesor, "No puede estar vacio");

            }
           

            if (!string.IsNullOrEmpty(textNombreMateria.Text) && !string.IsNullOrEmpty(textProfesor.Text) )
            {

                validar = true;
                errorProvider1.Clear();
            }

            return validar;
        }

        private bool ValidarDatos()
        {
            bool validar = true;
            
            List<Materia> listmaterias = new List<Materia>();
            listmaterias = MateriaN.CargarMaterias();


           if (textNombreMateria.Text!=mat.Nombre )

           {

            foreach(Materia m in listmaterias){

                    if (m.Nombre == textNombreMateria.Text)
                    {
                        MessageBox.Show("Ya existe una Materia con el nombre que trata de ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);


                        validar = false;
                    }
                    
                   

                    }

               

            }
            return validar;

        }



        
    }

    }
