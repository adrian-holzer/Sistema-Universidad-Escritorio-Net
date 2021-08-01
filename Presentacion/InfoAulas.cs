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
    public partial class InfoAulas : Form
    {
        public InfoAulas()
        {
            InitializeComponent();
        }

        private void InfoAulas_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }


        private void CargarDGV()
        {
            List<Aula> listaAulas = AulaN.ListarAulas();
           
            foreach (Aula aula in listaAulas)
            {
  Curso c = CursoN.BuscaCursoPorAula(aula.idAula);

                bool conexionared = Convert.ToBoolean(aula.ConexionRed);
                bool proyector = Convert.ToBoolean(aula.Proyector);
                string conex;
                string proy;

                if (conexionared == true)
                {
                    conex = "Si";
                }
                else {
                    conex = "No";
                }

                if (proyector == true)
                {
                    proy = "Si";
                }
                else
                {
                    proy = "No";
                }


                if (c!=null)
            {

                  
                      dataGridViewAulas.Rows.Add(aula.idAula,aula.NombreAula,conex,proy,aula.Capacidad,c.Nombre,"Modificar");
                    
            }
                else
                {
                    dataGridViewAulas.Rows.Add(aula.idAula, aula.NombreAula, aula.ConexionRed, aula.Proyector, aula.Capacidad, "--","Modificar");
                }

               


            }


        }

        private void dataGridViewAulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if ((e.ColumnIndex == dataGridViewAulas.Columns["Modificar"].Index))
            {
                Aula aula = AulaN.BuscarAula(Convert.ToInt32(dataGridViewAulas.CurrentRow.Cells["idaula"].Value));

                ModificarAula mod = new ModificarAula(aula);
                mod.ShowDialog();

                dataGridViewAulas.Rows.Clear();
                CargarDGV();


            }







            }
    }
}
