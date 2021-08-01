namespace Presentacion
{
    partial class ComprobanteInscripcionACursado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DivisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AlumnoBindingSource
            // 
            this.AlumnoBindingSource.DataSource = typeof(Datos.Alumno);
            // 
            // MateriaBindingSource
            // 
            this.MateriaBindingSource.DataSource = typeof(Datos.Materia);
            // 
            // ProfesorBindingSource
            // 
            this.ProfesorBindingSource.DataSource = typeof(Datos.Profesor);
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataSource = typeof(Datos.Curso);
            // 
            // DivisionBindingSource
            // 
            this.DivisionBindingSource.DataSource = typeof(Datos.Division);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlumnoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.MateriaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ProfesorBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.CursoBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.DivisionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ComprobanteInscripcionCursado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ComprobanteInscripcionACursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComprobanteInscripcionACursado";
            this.ShowIcon = false;
            this.Text = "Comprobante Inscripción a Cursado";
            this.Load += new System.EventHandler(this.ComprobanteInscripcionACursado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlumnoBindingSource;
        private System.Windows.Forms.BindingSource MateriaBindingSource;
        private System.Windows.Forms.BindingSource ProfesorBindingSource;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private System.Windows.Forms.BindingSource DivisionBindingSource;
    }
}