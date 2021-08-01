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
    public partial class Materias_Informacion : Form
    {
        public Materias_Informacion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridViewMateriasInfo.Rows.Clear();
            CargarDGV();





        }



        private void CargarDGV()
        {




            List<Materia> listaMaterias = new List<Materia>();
            if (string.IsNullOrEmpty(textBoxBuscarMat.Text))
            {

                listaMaterias = MateriaN.CargarMaterias();

            }
            else
            {
                dataGridViewMateriasInfo.Rows.Clear();
                listaMaterias = MateriaN.BuscarMateriaxNombre(textBoxBuscarMat.Text);


            }


            foreach (Materia m in listaMaterias)
            {



                Curso c = CursoN.BuscaCursoPorID(m.IdCurso);
                Aula aula = AulaN.BuscarAula(c.idAula);



                List<Correlativa> listaCorrelativas = CorrelativaN.ListaCorrelativas(m.idMateria);

                StringBuilder sb = new StringBuilder();

                if (listaCorrelativas.Count() == 0)
                {

                    dataGridViewMateriasInfo.Rows.Add(m.idMateria, m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, c.Nombre, aula.NombreAula, "--", "Ver Lista");
                }
                else
                {
                    foreach (Correlativa corr in listaCorrelativas)
                    {

                        sb.Append(corr.Nombre + "   | Requisito : " + corr.Requisito + "\n");

                    }

                    dataGridViewMateriasInfo.Rows.Add(m.idMateria, m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, c.Nombre, aula.NombreAula, sb, "Ver Lista");
                }



            }




        }





        private void Materias_Informacion_Load(object sender, EventArgs e)
        {
            dataGridViewMateriasInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            CargarDGV();
        }

        private void dataGridViewMateriasInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == dataGridViewMateriasInfo.Columns["AlumnosCursa"].Index))
            {

                Materias_Informacion_AlumnosCursa matAl = new Materias_Informacion_AlumnosCursa(MateriaN.BuscarMateriaPorID(Convert.ToInt32(dataGridViewMateriasInfo.CurrentRow.Cells[0].Value)));
                matAl.ShowDialog();






            }

          
        }
    }
}
