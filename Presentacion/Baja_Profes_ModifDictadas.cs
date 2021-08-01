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
    public partial class Baja_Profes_ModifDictadas : Form
    {
        List<Materia> list= new List<Materia>();
        List<Materia> listaMateria2 = new List<Materia>();
        List<Profesor> listPorfesores_1 = ProfesorN.CargarProfesores();
        Profesor p= new Profesor();

        // recibo la lista de materias que dicta el docente que se va a eliminar y el docente en cuestion
        public Baja_Profes_ModifDictadas(List<Materia> listaMateria,Profesor p)
        {
            this.list = listaMateria;
            this.p = p;
            InitializeComponent();
        }
        public Baja_Profes_ModifDictadas()
        {
            InitializeComponent();
        }
        private void Baja_Profes_ModifDictadas_Load(object sender, EventArgs e)
        {
           //Cargo el combobox de entrada con la lista completa de materias y con los profesores disponibles , excepto el que se va a eliminar
            CargarComboMaterias(null);
            CargarComboProfesores();



        }
        private void CargarComboMaterias(List<Materia> listMat)
        {
            // lista para filtrar materias que se van agregando

            List<Materia> listaFiltrada = new List<Materia>();
            int cont = 0;
            if (listMat==null )
            {
            comboBoxMaterias.DataSource = list;
            comboBoxMaterias.ValueMember = "idMateria";
            comboBoxMaterias.DisplayMember = "Nombre";
            }
            else
            {
                // recorro materias dictadas y comparo con lo que voy agragando al datagrid para que no se 
                // repita la materia en el combobox
                foreach (Materia m in list)
                {
                    cont = 0;
                    foreach (Materia mat in listMat)
                    {
                        if (m.idMateria==mat.idMateria)
                        {
                            cont++;
                        }
                    }
                    if (cont==0)
                    {
                        listaFiltrada.Add(m);
                    }

                }

                //Cargo el combo box con la / las materias que van quedando en el combo para asignar un docente
                comboBoxMaterias.DataSource = listaFiltrada;
                comboBoxMaterias.ValueMember = "idMateria";
                comboBoxMaterias.DisplayMember = "Nombre";


            }
            


        }



       



        private void CargarComboProfesores()
        {
            
            List<Profesor> listPorfesores_2 = new List<Profesor>();
            // Cargo los profesores en el combobox filtrando los profesores que no son el que quiero eliminar
            foreach (Profesor profe in listPorfesores_1)
            {
                if (profe.Legajo!=p.Legajo)
                {
                    listPorfesores_2.Add(profe);
                }

            }
            comboBoxProfesor.DataSource = listPorfesores_2;
            comboBoxProfesor.ValueMember = "Legajo";
            comboBoxProfesor.DisplayMember = "NombreYApellido";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // voy registrando en el datagrid los nuevos docentes seleccionado para cada materia que se quedaria sin docente
            //Capturo la excepcion en caso de que se quiera segur registrando materias y que no existan mas
            try
            {
                Materia m = MateriaN.BuscarMateriaPorID(Convert.ToInt32(comboBoxMaterias.SelectedValue));
                Profesor p = ProfesorN.BuscarxLegajo(Convert.ToInt32(comboBoxProfesor.SelectedValue));

                listaMateria2.Add(m);

                CargarComboMaterias(listaMateria2);

                dataGridView1.Rows.Add(p.Legajo, p.NombreYApellido, m.idMateria, m.Nombre, "Eliminar");
            }
            catch (InvalidOperationException ex) {

                MessageBox.Show("No hay mas Materias que asignar","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("¿Desea dar de baja al docente {0}?",p.NombreYApellido),"Baja Profesor", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

// Asigno los nuevos profesores de las materias que se quedarian sin docente
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                Materia m = MateriaN.BuscarMateriaPorID(Convert.ToInt32(dr.Cells[2].Value));
                m.Legajo = Convert.ToInt32(dr.Cells[0].Value);
                MateriaN.ModificarMateria(m);

            }
                //Elimino al docente seleccionado
                //Capturo la excepcion en caso de que se quiera eliminar el docente antes de asignar las materias a un nuevo docente
                try {
                    
                 ProfesorN.BajaProfesores(p);
                    
                   


                    //Cierro la ventana

                    this.Close();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show("Debe asignar las Materias a un nuevo docente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            


        }

        private void comboBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }
    }
}
