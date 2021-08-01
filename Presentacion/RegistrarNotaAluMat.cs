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
    public partial class RegistrarNotaAluMat : Form
    {
        RegistrarNotaAlumnos regA = new RegistrarNotaAlumnos();
        List<CursoMateria> listaCM = new List<CursoMateria>();
        
        public RegistrarNotaAluMat(RegistrarNotaAlumnos reg)
        {
            this.regA = reg;

           
            InitializeComponent();
        }

        public RegistrarNotaAluMat()
        {
           
            InitializeComponent();
        }


        private void RegistrarNotaAluMat_Load(object sender, EventArgs e)
        {
            textBoxAlumno.Text = regA.dataGridViewAlumnos.CurrentRow.Cells[1].Value.ToString();
            textBoxMatricula.Text = regA.dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();

            listaCM = CursoMateriaN.listaCursoMateriaPorMatricula(Convert.ToInt32(regA.dataGridViewAlumnos.CurrentRow.Cells[0].Value));

            CargarDGV(listaCM);
        }


        private void CargarDGV(List<CursoMateria> listacm)
        {

      


            foreach (CursoMateria cm in listaCM)
            {
                
                if (cm.Estado=="Cursando")
                {
                    dataGridViewNotas.Rows.Add(cm.idCursoMateria,MateriaN.BuscarMateriaPorID(cm.idMateria).Nombre,cm.Estado,"Registrar Notas");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


           












        }

        private void dataGridViewNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dataGridViewNotas.Columns["Notas"].Index))
            {



                RegistrarParciales_Recuperatorios registrar = new RegistrarParciales_Recuperatorios(this);
                registrar.ShowDialog();


            }





            }
        }
}
