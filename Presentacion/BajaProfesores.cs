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
    public partial class BajaProfesores : Form
    {
        List<Profesor> listaProfesores = new List<Profesor>();
        public BajaProfesores()
        {
            InitializeComponent();
        }

        private void textBoxBuscarProfe_TextChanged(object sender, EventArgs e)
        {

            CargarDGV();
        }

        private void CargarDGV()
        {
            //Si el textbox esta vacio lleno el datagrid con todos los elementos

            if (string.IsNullOrEmpty(textBoxBuscarProfe.Text))
            {
                dataGridViewProfes.Rows.Clear();
                listaProfesores = ProfesorN.CargarProfesores();
                foreach (Profesor p in listaProfesores)
                {
                    List<Materia> listaMateriasDictadas = ProfesorN.MateriasDictadas(p.Legajo);
                    if (listaMateriasDictadas == null)
                    {
                        dataGridViewProfes.Rows.Add(p.Legajo, p.NombreYApellido, p.Direccion, p.Telefono, p.DNI, "--", "Eliminar","Modificar");

                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (Materia m in listaMateriasDictadas)
                        {
                            sb.Append(m.Nombre + "\n");

                        }



                        dataGridViewProfes.Rows.Add(p.Legajo, p.NombreYApellido, p.Direccion, p.Telefono, p.DNI, sb, "Eliminar","Modificar");

                    }

                }

            }
            //De lo contrario lo lleno con los que se parecen al nombre que estoy ingresando , va cambiando a medida que se escribe
            else
            {

                dataGridViewProfes.Rows.Clear();
                listaProfesores = ProfesorN.BuscarProfesorxNombre(textBoxBuscarProfe.Text);
                foreach (Profesor p in listaProfesores)
                {
                    List<Materia> listaMateriasDictadas = ProfesorN.MateriasDictadas(p.Legajo);

                    // Si no dicta materias aun, ponemos --
                    if (listaMateriasDictadas == null)
                    {
                        dataGridViewProfes.Rows.Add(p.Legajo, p.NombreYApellido, p.Direccion, p.Telefono, p.DNI, "--", "Eliminar","Modificar");

                    }
                    else
                    {
                        //Usamos string builder para anexar los nombres de las materias q dictan y luego lo muestro en el datagrid

                        StringBuilder sb = new StringBuilder();
                        foreach (Materia m in listaMateriasDictadas)
                        {
                            sb.Append(m.Nombre + "\n");

                        }



                        dataGridViewProfes.Rows.Add(p.Legajo, p.NombreYApellido, p.Direccion, p.Telefono, p.DNI, sb, "Eliminar","Modificar");

                    }

                }




            }




        }

        private void BajaProfesores_Load(object sender, EventArgs e)
        {
            //Esta instruccio permite uqe las celdas de expandan cuando hay saltos de linea
            dataGridViewProfes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            CargarDGV();
        }

        private void dataGridViewProfes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.ColumnIndex == dataGridViewProfes.Columns["Eliminar"].Index))
            {
                //Capturo el profesor seleccionado (row) y listo las materias que dicta
                List<Materia> listMateriasDictadas = ProfesorN.MateriasDictadas(Convert.ToInt32(dataGridViewProfes.CurrentRow.Cells["Legajo"].Value));

                //Si la cantidad de docentes es = 1 , no dejo q lo elimine 
                if (dataGridViewProfes.Rows.Count == 1)
                {
                    MessageBox.Show("Solo existe un docente. No puede ser eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);return;
                }
                //Si aun no tiene nada asignado solo lo elimino
                if (listMateriasDictadas==null)
                {
                    Profesor profe = ProfesorN.BuscarxLegajo(Convert.ToInt32(dataGridViewProfes.CurrentRow.Cells[0].Value));
                    if (MessageBox.Show(string.Format("¿Desea dar de baja al docente {0}?", profe.NombreYApellido), "Baja Profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                   
                   
                    ProfesorN.BajaProfesores(profe);
                    dataGridViewProfes.Rows.Remove(dataGridViewProfes.CurrentRow);

                    }
                     
                }
                else
                {
                    // En caso de que el docente tenga asignadas materias, debo asignar nuevos docentes para esa materia : 
                    // abro un nuevo formulario para asignar un nuevo docente a las materias dictadas por el profesores que sera eliminado


                    Profesor p = ProfesorN.BuscarxLegajo(Convert.ToInt32(dataGridViewProfes.CurrentRow.Cells[0].Value));
                Baja_Profes_ModifDictadas bj = new Baja_Profes_ModifDictadas(listMateriasDictadas,p);
                bj.ShowDialog();
                    // dataGridViewProfes.Rows.Remove(dataGridViewProfes.CurrentRow);
                    //Refresco y vuelvo a cargar el datagrid
                    dataGridViewProfes.Rows.Clear();
                    CargarDGV();
                }
                
               





            }



            //Si el boton apretado es el de modificar
            if ((e.ColumnIndex == dataGridViewProfes.Columns["Modificar"].Index))
            {
                //busco el profesor segun el legajo en el datagridview que eesta en la celda [0]
                Profesor profe = ProfesorN.BuscarxLegajo(Convert.ToInt32(dataGridViewProfes.CurrentRow.Cells[0].Value));
                ModificarProfesor mod = new ModificarProfesor(profe);
                mod.ShowDialog();
                dataGridViewProfes.Rows.Clear();
                CargarDGV();

            }

















            }
    }
}
