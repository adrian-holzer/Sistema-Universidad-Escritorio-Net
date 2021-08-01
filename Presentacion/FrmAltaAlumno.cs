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
    public partial class FrmAltaAlumno : Form
    {

        Curso c = new Curso();
        Alumno alumnoNuevo = new Alumno();
        List<Materia> listmateria = new List<Materia>();
        List<Materia> listmateria2 = new List<Materia>();
        List<Correlativa> listCorr = new List<Correlativa>();
        List<Profesor> listaProfes = new List<Profesor>();
        Division d = new Division();
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            dataGridViewLiatadoMat.AutoGenerateColumns = false;
            btnComprobante.Enabled = false;
            c = CursoN.BuscaCursoPorNombre("1");

            CargarDGV();
            CargarComboDivision();
        }









        private void CargarDGV()
        {
           
            

            listmateria = CursoN.ListarMateriasPorCurso(c);
            

            foreach (Materia m in listmateria)
            {
                
                listCorr = CorrelativaN.ListaCorrelativas(m.idMateria);
                
                if (listCorr.Count()==0)
                {
                    listmateria2.Add(m);
                }
               

            }


            foreach (Materia m in listmateria2)
            {
                listaProfes.Add(ProfesorN.BuscarxLegajo(m.Legajo));
               dataGridViewLiatadoMat.Rows.Add(m.idMateria, m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido);

            }



           
            


        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            int  val = 0;
            if (ValidarFormulario()==true) { 
          

            alumnoNuevo.NombreYApellido = textBoxNombre.Text + " " + textBoxApellido.Text;
            alumnoNuevo.Direccion = textBoxDireccion.Text;
            alumnoNuevo.Telefono = textBoxTelefono.Text;
             d = DivisionN.BuscarDivisionporID(Convert.ToInt32(comboBoxDivision.SelectedValue));

        
            Aula aula = AulaN.BuscarAula(c.idAula);

               
                
               

                foreach (DataGridViewRow dr in dataGridViewLiatadoMat.Rows)
                {
                    
                    CursoMateria cursoMateriaNuevo = new CursoMateria();

                    if (CursoMateriaN.listaCursoMateria(Convert.ToInt32(comboBoxDivision.SelectedValue), Convert.ToInt32(dr.Cells[0].Value), "Cursando").Count() + 1 > aula.Capacidad)
                    {

                        val = 1;
                    }
                    
                }

                if (val == 0)
                {

                    AlumnoN.AltaAlumno(alumnoNuevo);

                    foreach (DataGridViewRow dr in dataGridViewLiatadoMat.Rows)
                    {

                        CursoMateria cursoMateriaNuevo = new CursoMateria();


                        cursoMateriaNuevo.idMateria = Convert.ToInt32(dr.Cells[0].Value);
                        cursoMateriaNuevo.Matricula = alumnoNuevo.Matricula;
                        cursoMateriaNuevo.idDivision = Convert.ToInt32(comboBoxDivision.SelectedValue);
                        cursoMateriaNuevo.Estado = "Cursando";



                        CursoMateriaN.AltaCursoMateria(cursoMateriaNuevo);

                    }






                        MessageBox.Show(string.Format("Se ha matriculado al Alumno {0} \n Nº Matrícula : {1}", alumnoNuevo.NombreYApellido, alumnoNuevo.Matricula), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnComprobante.Enabled = true;
                    btnMatricular.Enabled = false;
                    
                }
                else {

                MessageBox.Show("No hay cupo en la Division en la que se está tratando de Matricular", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }

            
            

        }
          
        


        private void CargarComboDivision()
        {

            comboBoxDivision.DataSource = DivisionN.ListarDivisiones(c);
            comboBoxDivision.ValueMember = "idDivision";
            comboBoxDivision.DisplayMember = "NombreDivision";


        }

        private bool ValidarFormulario()
        {

            bool validar = false;

            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre,"No puede estar vacio");
            }
          
            if (string.IsNullOrEmpty(textBoxApellido.Text))
            {
                errorProvider1.SetError(textBoxApellido, "No puede estar vacio");
            }
           
            if (string.IsNullOrEmpty(textBoxDireccion.Text))
            {
                errorProvider1.SetError(textBoxDireccion, "No puede estar vacio");
            }
           
            if (string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                errorProvider1.SetError(textBoxTelefono, "No puede estar vacio");
            }
           


            if (!string.IsNullOrEmpty(textBoxNombre.Text) && !string.IsNullOrEmpty(textBoxApellido.Text) && !string.IsNullOrEmpty(textBoxDireccion.Text)&& !string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                errorProvider1.Clear();
                validar = true;
            }
            return validar;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {

           

            ComprobanteAltaAlumno comprobanteAlta = new ComprobanteAltaAlumno();
            comprobanteAlta.nuevo.Add(alumnoNuevo);
            comprobanteAlta.materias = listmateria2;
            comprobanteAlta.profesores = listaProfes;
            comprobanteAlta.curso.Add(c);
            comprobanteAlta.division.Add(d);
            comprobanteAlta.Show();
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
