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
    public partial class Info_Curso_Materias : Form
    {
        Curso curso = new Curso();
        List<Materia> listaMaterias;
        List<Correlativa> listaCorrelativas;
        public Info_Curso_Materias(Curso curso)
        {
            this.curso = curso;
            listaMaterias = new List<Materia>();
            listaCorrelativas = new List<Correlativa>();
            InitializeComponent();
        }

        private void Info_Curso_Materias_Load(object sender, EventArgs e)
        {
            dataGridViewMaterias_Curso.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            CargarDGV();
        }


        private void CargarDGV()
        {
            listaMaterias = CursoN.ListarMateriasPorCurso(curso);
           
            foreach (Materia m in listaMaterias)
            {
               StringBuilder sb = new StringBuilder();
               listaCorrelativas= CorrelativaN.ListaCorrelativas(m.idMateria);
                if (listaCorrelativas.Count() == 0)
                {

                    dataGridViewMaterias_Curso.Rows.Add(m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, "--");
                }
                else
                {
                    foreach (Correlativa c in listaCorrelativas)
                    {

                        sb.Append(c.Nombre + "   | Requisito : " + c.Requisito +"\n" );
                       
                    }

                    dataGridViewMaterias_Curso.Rows.Add(m.Nombre, ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, sb);
                }
            }



        }

        private void dataGridViewMaterias_Curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
