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
    public partial class AlumnoBaja : Form
    {
        public List<Alumno> listaAlumnos = new List<Alumno>();

        public AlumnoBaja()
        {
            InitializeComponent();
        }
       
        private void CargarDGV(List<Alumno> listaAlumnos)
        {
            foreach (Alumno a in listaAlumnos)
            {

                dataGridViewAlumnos.Rows.Add(a.Matricula, a.NombreYApellido,a.Direccion,a.Telefono, "Eliminar","Editar");

            }



        }

        private void Refrescar()
        {
            dataGridViewAlumnos.Rows.Clear();
            CargarDGV(AlumnoN.CargarAlumnos());
        }

        private void AlumnoBaja_Load(object sender, EventArgs e)
        {


            textBoxNo.Visible = false;
            if (AlumnoN.CargarAlumnos() != null)
            {
                listaAlumnos = AlumnoN.CargarAlumnos();
            }
            else
            {

                textBoxNo.Visible = true;
            }

            dataGridViewAlumnos.AutoGenerateColumns = false;
            CargarDGV(listaAlumnos);

        }



       


     

        private void textBoxMatriculaBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMatriculaBuscar.Text))

            {
                dataGridViewAlumnos.Rows.Clear();
                CargarDGV(listaAlumnos);
            }
            else
            {
                try {  dataGridViewAlumnos.Rows.Clear();
                CargarDGV(AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(textBoxMatriculaBuscar.Text)));

                }
                catch (Exception ex) { }
               

            }


        }

        private void dataGridViewAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dataGridViewAlumnos.Columns["Eliminar"].Index))
            {
                Alumno alumno = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells[0].Value)).ElementAt(0);
                if (MessageBox.Show(string.Format("¿Desea dar de Baja la Matrícula {0}?",alumno.Matricula),"Baja",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {

                   

                    List<CursoMateria> listCursoMateria = CursoMateriaN.listaCursoMateriaPorMatricula(alumno.Matricula);


                    foreach (CursoMateria cm in listCursoMateria)
                    {
                        CursoMateriaN.BajaxIDCurso_Materia(cm.idCursoMateria);
                    }

                    AlumnoN.BajaAlumno(alumno);


                    MessageBox.Show(string.Format("Se ha dado de baja al Alumno {0} con Matrícula : {1}", alumno.NombreYApellido, alumno.Matricula), "Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridViewAlumnos.Rows.Remove(dataGridViewAlumnos.CurrentRow);
                }

            }




            if ((e.ColumnIndex == dataGridViewAlumnos.Columns["Editar"].Index))
            {


                Alumno al = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(dataGridViewAlumnos.CurrentRow.Cells[0].Value)).ElementAt(0);


              

                    AlumnoModificar alumnoModificar = new AlumnoModificar(al);

                    alumnoModificar.ShowDialog();

                    Refrescar();

                







            }
        }

        private void textBoxNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
