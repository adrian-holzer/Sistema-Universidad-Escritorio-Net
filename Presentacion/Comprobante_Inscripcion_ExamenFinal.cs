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
    public partial class Comprobante_Inscripcion_ExamenFinal : Form
    {

        public List<Alumno> nuevo = new List<Alumno>();
        public List<Materia> materias = new List<Materia>();
        public List<Profesor> profesores = new List<Profesor>();

        public Comprobante_Inscripcion_ExamenFinal()
        {
            InitializeComponent();
        }

        private void Comprobante_Inscripcion_ExamenFinal_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", nuevo));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", materias));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", profesores));

            this.reportViewer1.RefreshReport();
        }
    }
}
