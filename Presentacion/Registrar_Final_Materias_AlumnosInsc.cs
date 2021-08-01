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
    public partial class Registrar_Final_Materias_AlumnosInsc : Form
    {
        Materia materia;
        List<Final> listaFinales = new List<Final>();
        List<CursoMateria> listaCursoMateria = new List<CursoMateria>();
        List<CursoMateria> listaCursoMateria2 = new List<CursoMateria>();
        List<Alumno> listaAlumnos = new List<Alumno>();

        public Registrar_Final_Materias_AlumnosInsc(Materia mat)
        {
            this.materia = mat;
            InitializeComponent();
        }

        private void Registrar_Final_Materias_AlumnosInsc_Load(object sender, EventArgs e)
        {
            labelA.Text = string.Format("Alumnos Inscriptos a la Materia {0}", materia.Nombre);
            CargarDGV();

        }


        private void CargarDGV()
        {

            listaCursoMateria = CursoMateriaN.listaCursoMateria(materia.idMateria);

            foreach (CursoMateria cm in listaCursoMateria)
            {

                if (cm.Inscripcion_EFinal=="Inscripción Confirmada")
                {

                    listaCursoMateria2.Add(cm);

                }

            }

            if (listaCursoMateria2.Count==0)
            {
                MessageBox.Show("No hay alumnos Inscriptos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                

          foreach(CursoMateria cm in listaCursoMateria2){

                Alumno a = AlumnoN.BuscarAlumnoxMatricula(cm.Matricula).ElementAt(0);
                Final f = FinalN.BuscarFinal(cm.idCursoMateria);

                dataGridViewAlumnosFinal.Rows.Add(a.Matricula, a.NombreYApellido,f.EstadoEFinal,"--","Registrar");



            }

            }
            

          



        }

        private void Refrescar()
        {

            dataGridViewAlumnosFinal.Rows.Clear();
            CargarDGV();
        }

        private void dataGridViewAlumnosFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






            if ((e.ColumnIndex == dataGridViewAlumnosFinal.Columns["RegistrarNota"].Index))
            {
               
                Registrar_Final_Materias_AlumnosInsc_Nota reg = new Registrar_Final_Materias_AlumnosInsc_Nota(this);
                reg.ShowDialog();
            }





            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, contador2 = 0;



            if (MessageBox.Show(string.Format("¿Desea registrar las Notas de Examen Final de la Materia {0}?", materia.Nombre), "Registrar Finales", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {    //Listo todos los cursos Materias de la materia en cuestion

                listaCursoMateria = CursoMateriaN.listaCursoMateria(materia.idMateria);
                listaCursoMateria2.Clear();
                //Recorro y asigno a otra lista aquellos cursomateria en los que el estado de inscripcion a final es = a "Inscripcion Confirmada"
                foreach (CursoMateria cm in listaCursoMateria)
                {

                    if (cm.Inscripcion_EFinal == "Inscripción Confirmada")
                    {

                        listaCursoMateria2.Add(cm);

                    }

                }

                //Recorro cada fila del datagrid  para comprobar que se haya completado todos los campos


                int cont = 0;

                foreach(DataGridViewRow dr in dataGridViewAlumnosFinal.Rows)

                {

                    if (dr.Cells[2].Value=="Inscripto"|| dr.Cells[3].Value == "--") {
                        cont++;
                    }







                }

                if (cont!=0)
                {

                    MessageBox.Show("Faltan Notas ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                
                if(cont==0)
                {
                 
                    foreach (CursoMateria cm in listaCursoMateria2)
                    {
                        Console.WriteLine(listaCursoMateria2.Count);

                        listaFinales = FinalN.ListarFinales(cm.idCursoMateria);



                        foreach (Final f in listaFinales)
                        {
                            if (f.EstadoEFinal=="Desaprobado")
                            {
                                contador2++;
                            }


                        }

                        if (contador2 == 3 && (dataGridViewAlumnosFinal.Rows[i].Cells[2].Value.ToString() == "Desaprobado"))
                        {
                            //Elimino todos los finales y ese curso Materia en cascada

                            FinalN.BajaFinales(cm.idCursoMateria);

                            CursoMateriaN.BajaxIDCurso_Materia(cm.idCursoMateria);
                           
                            

                        }
                        else
                        {

                           
                            
                            Final f = FinalN.BuscarFinal(cm.idCursoMateria);

                            Console.WriteLine(f.EstadoEFinal);

                            f.EstadoEFinal = dataGridViewAlumnosFinal.Rows[i].Cells[2].Value.ToString();

                            if (f.EstadoEFinal == "Ausente")
                            {

                                f.NotaExamen = -1;
                            }
                            else if (f.EstadoEFinal == "Aprobado" || f.EstadoEFinal == "Desaprobado")
                            {
                                f.NotaExamen = Convert.ToInt32(dataGridViewAlumnosFinal.Rows[i].Cells[3].Value);

                            }


                            FinalN.ActualizarFinal(f);


                            if (f.EstadoEFinal == "Aprobado")
                            {
                                cm.Estado = "Aprobado";
                                cm.NotaFinal = f.NotaExamen;
                                cm.Inscripcion_EFinal = "--";
                                CursoMateriaN.RegistrarNotas(cm);
                            }
                            else
                            {
                                cm.Inscripcion_EFinal = "--";
                                CursoMateriaN.RegistrarNotas(cm);

                            }

                        }
                        i++;






                    }

                    MessageBox.Show("Se han registrado las Notas ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Console.WriteLine(i);
                    Console.WriteLine(listaCursoMateria2.Count());
                }
            }










        }
    }
}
