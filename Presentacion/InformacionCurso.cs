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
    public partial class InformacionCurso : Form
    {
        List<Curso> listaCursos;
        List<Division> listaDivisiones;
        public InformacionCurso()
        {
            listaCursos = new List<Curso>();
            listaDivisiones = new List<Division>();
            InitializeComponent();
        }

        private void InformacionCurso_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void CargarDGV()
        {
           
            listaCursos = CursoN.ListarCursosPorNombre();
            
            foreach (Curso c in listaCursos)
            {
                StringBuilder sb = new StringBuilder();
                listaDivisiones = DivisionN.ListarDivisiones(c);
                Aula aula = AulaN.BuscarAula(c.idAula);
                foreach (Division d in listaDivisiones)
                {
                    
                    sb.Append(d.NombreDivision);

                }
                
                dataGridViewCursos.Rows.Add(c.idCurso,c.Nombre, sb ,aula.NombreAula, "Información");
                
            }
            


        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if ((e.ColumnIndex == dataGridViewCursos.Columns["Información"].Index))
            {
                Curso curso = CursoN.BuscaCursoPorID(Convert.ToInt32(dataGridViewCursos.CurrentRow.Cells[0].Value));
                Info_Curso_Materias info_Curso_Materias = new Info_Curso_Materias(curso);
                info_Curso_Materias.ShowDialog();



            }






            }
        }
}
