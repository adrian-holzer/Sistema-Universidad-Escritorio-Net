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
    public partial class ListaMateriasAprobadas : Form
    {

        Alumno alumno = new Alumno();
        List<CursoMateria> listCursoMateria = new List<CursoMateria>();


        public ListaMateriasAprobadas(Alumno al)
        {
            this.alumno = al;
            listCursoMateria = CursoMateriaN.listaCursoMateriaPorMatricula(alumno.Matricula);

            InitializeComponent();
        }

        private void ListaMateriasAprobadas_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }


        private void CargarDGV()
        {

            List<CursoMateria> listCursoMateriaAprobado = new List<CursoMateria>();
            foreach (CursoMateria cm in listCursoMateria)
            {

                if (cm.Estado == "Aprobado")
                {

                    listCursoMateriaAprobado.Add(cm);

                }

            }


            foreach (CursoMateria cm in listCursoMateriaAprobado)
            {

                Materia m = MateriaN.BuscarMateriaPorID(cm.idMateria);
                Division d = DivisionN.BuscarDivisionporID(Convert.ToInt32(cm.idDivision));
                Curso c = CursoN.BuscaCursoPorID(d.idDivision);

                if (cm.PrimerRecuperatorio == null && cm.SegundoRecuperatorio == null)
                {

                    dataGridViewAprobadas.Rows.Add(m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, cm.PrimerParcial, cm.SegundoParcial, cm.TercerParcial, "-", "-",cm.NotaFinal);
                }

                if (cm.PrimerRecuperatorio != null && cm.SegundoRecuperatorio == null)
                {

                    dataGridViewAprobadas.Rows.Add(m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, cm.PrimerParcial, cm.SegundoParcial, cm.TercerParcial, cm.PrimerRecuperatorio, "-", cm.NotaFinal);
                }

                if (cm.PrimerRecuperatorio != null && cm.SegundoRecuperatorio != null)
                {

                    dataGridViewAprobadas.Rows.Add(m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, cm.PrimerParcial, cm.SegundoParcial, cm.TercerParcial, cm.PrimerRecuperatorio, cm.SegundoRecuperatorio, cm.NotaFinal);
                }




            }



        }
    }
}
