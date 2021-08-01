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
    public partial class Materias_Informacion_AlumnosCursa : Form
    {
        Materia materia;
        public Materias_Informacion_AlumnosCursa(Materia m)
        {
            this.materia = m;
            InitializeComponent();
        }

        private void Materias_Informacion_AlumnosCursa_Load(object sender, EventArgs e)
        {
            lblSAl.Visible = false;
            CargarDGV();
        }


        private void CargarDGV()
        {

            List<CursoMateria> listaCursoMateriaCursando = CursoMateriaN.listaCursoMateriaPorIDMateria(materia.idMateria,"Cursando");

            if (listaCursoMateriaCursando==null)
            {

                lblSAl.Visible = true;

            }
            else
            {
                foreach (CursoMateria cm in listaCursoMateriaCursando)
            {

                Alumno alumno = AlumnoN.BuscarAlumnoxMatricula(cm.Matricula).ElementAt(0);
                Division d = DivisionN.BuscarDivisionporID(Convert.ToInt32(cm.idDivision));
                dataGridView1.Rows.Add(alumno.Matricula,alumno.NombreYApellido,d.NombreDivision);


            }


            }

            


        }
    }
}
