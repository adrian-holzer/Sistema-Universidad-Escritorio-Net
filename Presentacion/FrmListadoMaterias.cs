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
    public partial class FrmListadoMaterias : Form
    {
       public  FrmInscribirAMateria frminscribirMat = new FrmInscribirAMateria();
        List<Materia> listMateria = new List<Materia>();

        List<Materia> listMaterianueva = new List<Materia>();

        List<CursoMateria> listCursoMateria = new List<CursoMateria>();

        List<Correlativa> listCorrelativas = new List<Correlativa>();
        List<Correlativa> listCorrelativas2 = new List<Correlativa>();

        public Materia m = new Materia();

        public FrmListadoMaterias(FrmInscribirAMateria frmInscribirAMateria)
        {

            this.frminscribirMat = frmInscribirAMateria;
            InitializeComponent();
        }

        public FrmListadoMaterias()
        {

            
            InitializeComponent();
        }

        private void FrmListadoMaterias_Load(object sender, EventArgs e)
        {
            listMateria = MateriaN.CargarMaterias();
            listCursoMateria = CursoMateriaN.listaCursoMateriaPorMatricula(Convert.ToInt32(frminscribirMat.dataGridViewAlumnos.CurrentRow.Cells[0].Value));
            CargarDGV();


        }


        internal void CargarDGV()
        {
            bool existe = false;
            foreach (Materia m in listMateria)
            {
                existe = false;
                foreach (CursoMateria cm in listCursoMateria)
                {

                    if (m.idMateria==cm.idMateria)
                    {
                        existe = true;
                    }

                }

                if (existe==false) {
                    listMaterianueva.Add(m);
                }


            }
           
            foreach (Materia m in listMaterianueva)
            {
        dataGridViewMaterias.Rows.Add(m.idMateria,m.Nombre,ProfesorN.BuscarxLegajo(m.Legajo).NombreYApellido, CursoN.BuscaCursoPorID(m.IdCurso).Nombre,"Inscribir");

            }
            


        }

        private void dataGridViewMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lo de division

            
            Alumno alumno = AlumnoN.BuscarAlumnoxMatricula(Convert.ToInt32(frminscribirMat.dataGridViewAlumnos.CurrentRow.Cells[0].Value)).ElementAt(0);
            if ((e.ColumnIndex == dataGridViewMaterias.Columns["Inscribir"].Index))
            {

                listCorrelativas.Clear();
                listCorrelativas2.Clear();
                m = MateriaN.BuscarMateriaPorID(Convert.ToInt32(dataGridViewMaterias.CurrentRow.Cells[0].Value));

                listCorrelativas = CorrelativaN.ListaCorrelativas(m.idMateria);

                int contCorr = 0, cont2 = 0;

                //verifico correlativas


                foreach (Correlativa cor in listCorrelativas)
                {

                    foreach (CursoMateria cm in listCursoMateria)
                    {

                        Materia mat = MateriaN.BuscarMateriaPorID(cm.idMateria);

                        if (cor.Nombre == mat.Nombre)
                        {

                            if (cor.Requisito == "Regular")
                            {

                                if (cm.Estado == "Regular" || cm.Estado == "Aprobado")
                                {
                                    contCorr++;


                                }

                                else
                                {
                                  listCorrelativas2.Add(cor);
                                }
                            }
                            if (cor.Requisito == "Aprobado")
                            {
                                if (cm.Estado == "Aprobado")
                                {
                                contCorr++;
                                }
                                else
                                {
                                 listCorrelativas2.Add(cor);
                                }
                               


                            }
                            
                        }

                   


                    }




                }
            
                    

                                  



                



                foreach (Correlativa c in listCorrelativas)
                {

                    if (!listCorrelativas2.Contains(c)){
                        listCorrelativas2.Add(c);
                    }
                }


                

                    if (contCorr==listCorrelativas.Count())
                {


                   
                    InscripcionCursado_Comprobante ins = new InscripcionCursado_Comprobante(this);
                    ins.ShowDialog();


                    
                    
                }

                else
                {

                    
                    StringBuilder sb = new StringBuilder();
                    
                    foreach (Correlativa c in listCorrelativas2){
                        sb.Append(string.Format("Correlativa  : {0}  - Requisito : {1} \n\n\n", c.Nombre, c.Requisito));
                    }

                    MessageBox.Show("Debe cumplir con las siguientes Correlatividadaes :\n\n\n "+sb,"Inscripcion a Materia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   
                }





            }




            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
