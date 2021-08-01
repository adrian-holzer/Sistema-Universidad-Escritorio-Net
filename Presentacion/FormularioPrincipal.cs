using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAltaMateria frmAltaMateria = new FrmAltaMateria();
            frmAltaMateria.MdiParent = this;
            frmAltaMateria.Show();


        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaMateria frmBaja = new FrmBajaMateria();
            frmBaja.MdiParent = this;
            frmBaja.Show();
        }

        private void modificarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarMateria frmModificar = new FrmModificarMateria();
            frmModificar.MdiParent = this;
            frmModificar.Show();
        }

        private void matricularAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno frmAltaAlumno = new FrmAltaAlumno();
            frmAltaAlumno.MdiParent = this;
            frmAltaAlumno.Show();
        }

        private void inscribirAMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscribirAMateria frmInscribirAMateria = new FrmInscribirAMateria();
            frmInscribirAMateria.MdiParent = this;
            frmInscribirAMateria.Show();
        }

        private void notasParcialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegistrarNotaAlumnos registrarNotaAlumnos = new RegistrarNotaAlumnos();
            registrarNotaAlumnos.MdiParent = this;
            registrarNotaAlumnos.Show();










        }

        private void bajaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoBaja alBaja = new AlumnoBaja();
            alBaja.MdiParent = this;
            alBaja.Show();
        }

        private void materiasEnCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoMateriasEstado alumnoMateriasEstado = new AlumnoMateriasEstado();
            alumnoMateriasEstado.MdiParent = this;
            alumnoMateriasEstado.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach(Control ctl in this.Controls)
            {

                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;


                }
                catch (InvalidCastException exc)
                {

                }


            }
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionCurso infoCurso = new InformacionCurso();
            infoCurso.MdiParent = this;
            infoCurso.Show();
        }

        private void informaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InfoAulas infoAula = new InfoAulas();
            infoAula.MdiParent = this;
            infoAula.Show();
        }

        private void informaciónToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Materias_Informacion materias_Informacion = new Materias_Informacion();
            materias_Informacion.MdiParent = this;
            materias_Informacion.Show();
        }

        private void inscribirAFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscribir_Final_Alumnos inscribirFinal = new Inscribir_Final_Alumnos();
            inscribirFinal.MdiParent = this;
            inscribirFinal.Show();
        }

        private void registrarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void finalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_Final_Materias reg_Final = new Registrar_Final_Materias();
            reg_Final.MdiParent = this;
            reg_Final.Show();

        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaProfesor altaprofe = new AltaProfesor();
            altaprofe.MdiParent = this;
            altaprofe.Show();
        }

        private void bajaDeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaProfesores bjProfe = new BajaProfesores();
            bjProfe.MdiParent = this;
            bjProfe.Show();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
