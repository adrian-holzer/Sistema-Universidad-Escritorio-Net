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
    public partial class InscripcionCursado_Comprobante : Form
    {
        FrmListadoMaterias frmListadoMaterias = new FrmListadoMaterias();
        Curso c = new Curso();
        public InscripcionCursado_Comprobante(FrmListadoMaterias frml)
        {
            this.frmListadoMaterias = frml;
            InitializeComponent();
        }

        private void InscripcionCursado_Comprobante_Load(object sender, EventArgs e)
        {
             c = CursoN.BuscaCursoPorID(Convert.ToInt32(frmListadoMaterias.m.IdCurso));
            CargarComboDivision();


            textBoxCurso.Text = c.Nombre;
            textBoxMatricula.Text= AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(frmListadoMaterias.frminscribirMat.dataGridViewAlumnos.CurrentRow.Cells[0].Value)).ElementAt(0).Matricula.ToString();
            textBoxNombreAlumno.Text = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(textBoxMatricula.Text)).ElementAt(0).NombreYApellido;
            textBoxMateria.Text = MateriaN.BuscarMateriaPorID(Convert.ToInt32(frmListadoMaterias.m.idMateria)).Nombre;
            textBoxProfesor.Text = ProfesorN.BuscarxLegajo(MateriaN.BuscarMateriaPorID(Convert.ToInt32(frmListadoMaterias.m.idMateria)).Legajo).NombreYApellido;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int val = 0;

            Aula aula = AulaN.BuscarAula(c.idAula);





                CursoMateria cursoMateriaNuevo = new CursoMateria();

                if (CursoMateriaN.listaCursoMateria(Convert.ToInt32(comboBoxDivision.SelectedValue), MateriaN.BuscarMateriaPorID(Convert.ToInt32(frmListadoMaterias.m.idMateria)).idMateria, "Cursando").Count() + 1 > aula.Capacidad)
                {

                    val = 1;
                }



            if (val == 0)
            {


                CursoMateria nuevo = new CursoMateria();
                nuevo.idMateria = frmListadoMaterias.m.idMateria;
                nuevo.Matricula = Convert.ToInt32(textBoxMatricula.Text);
                nuevo.idDivision = Convert.ToInt32(comboBoxDivision.SelectedValue);
                nuevo.Estado = "Cursando";
                CursoMateriaN.AltaCursoMateria(nuevo);

                MessageBox.Show("Se ha realizado la Inscripcion con éxito ", "Inscripcion a Cursado", MessageBoxButtons.OK, MessageBoxIcon.Information);



                comboBoxDivision.Enabled = false;
                btnComprobante.Enabled = true;
                btnInscribir.Enabled = false;

                frmListadoMaterias.dataGridViewMaterias.Rows.Remove(frmListadoMaterias.dataGridViewMaterias.CurrentRow);
               
            }

            else
            {

                MessageBox.Show("No hay cupo en la division en la que trata de inscribir", "Inscripcion a Cursado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        private void CargarComboDivision()
        {

            
            comboBoxDivision.DataSource = DivisionN.ListarDivisiones(c);
            comboBoxDivision.ValueMember = "idDivision";
            comboBoxDivision.DisplayMember = "NombreDivision";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {

            Alumno alumno = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(textBoxMatricula.Text)).ElementAt(0);
            Materia materia = MateriaN.BuscarMateriaPorID(Convert.ToInt32(frmListadoMaterias.m.idMateria));
            Profesor profe = ProfesorN.BuscarxLegajo(materia.Legajo);
            Division division = DivisionN.BuscarDivisionporID(Convert.ToInt32(comboBoxDivision.SelectedValue));

            ComprobanteInscripcionACursado comprobante = new ComprobanteInscripcionACursado();
            comprobante.nuevo.Add(alumno);
            comprobante.materias.Add(materia);
            comprobante.profesores.Add(profe) ;
            comprobante.curso.Add(c);
            comprobante.division.Add(division);
            comprobante.Show();


            this.Close();



        }
    }
}
