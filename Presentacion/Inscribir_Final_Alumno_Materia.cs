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
    public partial class Inscribir_Final_Alumno_Materia : Form
    {
        Alumno alumno;
        public Inscribir_Final_Alumno_Materia(Alumno al)
        {
            this.alumno = al;
            InitializeComponent();
        }

        private void Incribir_Final_Alumno_Materia_Load(object sender, EventArgs e)
        {
            
            textBoxMatricula.Text = alumno.Matricula.ToString();
            textBoxNombrAlumno.Text = alumno.NombreYApellido;
            textBoxMatricula.Enabled = false;
            textBoxNombrAlumno.Enabled = false;
            lbldisponibles.Visible = false;

            CargarDGV();

          


        }



        





        private void CargarDGV()
        {
            int cont = 0;
            List<CursoMateria> listaCursoMaterias = CursoMateriaN.listaCursoMateria_Matricula_Estado(alumno.Matricula,"Regular");
            List<CursoMateria> listaCursoMaterias2 = new List<CursoMateria>();
            List<Correlativa> listaCorrelativas = new List<Correlativa>();

            if (listaCursoMaterias!=null)
            {

                foreach (CursoMateria cm in listaCursoMaterias)
                {
                    cont = 0;
                    Materia m = MateriaN.BuscarMateriaPorID(cm.idMateria);

                    listaCorrelativas = CorrelativaN.ListaCorrelativas(m.idMateria);

                    listaCursoMaterias2 = CursoMateriaN.listaCursoMateriaPorMatricula(alumno.Matricula);

                    foreach (Correlativa corr in listaCorrelativas) {
                      
                        foreach (CursoMateria cursMat in listaCursoMaterias2)
                        {
                            Materia m2 = MateriaN.BuscarMateriaPorID(cursMat.idMateria);

                            if (m2.Nombre==corr.Nombre && cursMat.Estado=="Aprobado")
                            {
                                cont++;

                            }

                        }

                    }

                    if (cont==listaCorrelativas.Count())
                    {

                    Profesor p = ProfesorN.BuscarxLegajo(m.Legajo);
                        if (cm.Inscripcion_EFinal == "Inscripto") {
                            dataGridViewFinal.Rows.Add(m.idMateria, m.Nombre, p.NombreYApellido, cm.Inscripcion_EFinal);




                        }
                        else if (cm.Inscripcion_EFinal == "Inscripción Confirmada") {

                            dataGridViewFinal.Rows.Add(m.idMateria, m.Nombre, p.NombreYApellido, cm.Inscripcion_EFinal);



                        }
                        else
                        {

                            dataGridViewFinal.Rows.Add(m.idMateria, m.Nombre, p.NombreYApellido, "--");


                        }
                    }

                   
                   



                }




            }
            else
            {
                lbldisponibles.Visible = true;
              
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {

Materia materia = MateriaN.BuscarMateriaPorID(Convert.ToInt32(dataGridViewFinal.CurrentRow.Cells[0].Value));
                CursoMateria cm = CursoMateriaN.listaCursoMateria_Matricula_Materia(alumno.Matricula, materia.idMateria);

            if (cm.Inscripcion_EFinal == "Inscripción Confirmada")
            {
                // Solamente genero el comprobante



                Comprobante_Inscripcion_ExamenFinal comprobanteInscFinal = new Comprobante_Inscripcion_ExamenFinal();
                comprobanteInscFinal.nuevo.Add(alumno);
                comprobanteInscFinal.materias.Add(materia);
                comprobanteInscFinal.profesores.Add(ProfesorN.BuscarxLegajo(materia.Legajo));

                comprobanteInscFinal.ShowDialog();


            }
            else
            {
                if (MessageBox.Show("Si confirma la inscripción no podrá anularla. ¿Desea confirmar la inscripción ?", "Inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    Final final = new Final();
                    final.EstadoEFinal = "Inscripto";
                    final.idCursoMateria = cm.idCursoMateria;
                    FinalN.AltFinal(final);

                    cm.Inscripcion_EFinal = "Inscripción Confirmada";
                    CursoMateriaN.RegistrarNotas(cm);

                    dataGridViewFinal.Rows.Clear();
                    CargarDGV();


                    // genero el comprobante


                    Comprobante_Inscripcion_ExamenFinal comprobanteInscFinal = new Comprobante_Inscripcion_ExamenFinal();
                    comprobanteInscFinal.nuevo.Add(alumno);
                    comprobanteInscFinal.materias.Add(materia);
                    comprobanteInscFinal.profesores.Add(ProfesorN.BuscarxLegajo(materia.Legajo));

                    comprobanteInscFinal.ShowDialog();




                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {



            Materia materia = MateriaN.BuscarMateriaPorID(Convert.ToInt32(dataGridViewFinal.CurrentRow.Cells[0].Value));
            CursoMateria cm = CursoMateriaN.listaCursoMateria_Matricula_Materia(alumno.Matricula, materia.idMateria);
            
                cm.Inscripcion_EFinal = "Inscripto";
                CursoMateriaN.RegistrarNotas(cm);
            
                dataGridViewFinal.Rows.Clear();
                CargarDGV();
            
                MessageBox.Show(string.Format(" Inscripto  al Final de : {0} , Genere el comprobante para confirmar", materia.Nombre), "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
        

        private void dataGridViewFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

            Materia materia = MateriaN.BuscarMateriaPorID(Convert.ToInt32(dataGridViewFinal.CurrentRow.Cells[0].Value));
            CursoMateria cm = CursoMateriaN.listaCursoMateria_Matricula_Materia(alumno.Matricula, materia.idMateria);

            cm.Inscripcion_EFinal = "--";
            CursoMateriaN.RegistrarNotas(cm);
            dataGridViewFinal.Rows.Clear();
            CargarDGV();
            
        }

        private void dataGridViewFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridViewFinal_MouseClick(object sender, MouseEventArgs e)
        {

           

        }

        private void dataGridViewFinal_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFinal.CurrentRow.Cells[3].Value.ToString()== "Inscripto")
            {
                btnInscribir.Enabled = false;
                btnComprobante.Enabled = true;
                btnAnular.Enabled = true;

            }
           else if (dataGridViewFinal.CurrentRow.Cells[3].Value.ToString() == "Inscripción Confirmada")
            {
                btnInscribir.Enabled = false;
                btnComprobante.Enabled = true;
                btnAnular.Enabled = false;

            }
            else if(dataGridViewFinal.CurrentRow.Cells[3].Value.ToString() == "--")
            {

                btnInscribir.Enabled = true;
                btnComprobante.Enabled = false;
                btnAnular.Enabled = false;

            }
        }
    }
}
