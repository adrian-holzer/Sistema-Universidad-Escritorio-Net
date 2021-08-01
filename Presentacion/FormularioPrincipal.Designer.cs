namespace Presentacion
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricularAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirAMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirAFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasParcialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.materiasToolStripMenuItem1,
            this.aulasToolStripMenuItem,
            this.cursoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matricularAlumnoToolStripMenuItem,
            this.bajaDeAlumnoToolStripMenuItem,
            this.inscribirAMateriaToolStripMenuItem,
            this.inscribirAFinalToolStripMenuItem,
            this.registrarNotasToolStripMenuItem,
            this.verToolStripMenuItem});
            //this.altasToolStripMenuItem.Image = global::Presentacion.Properties.Resources.estudiante;
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.altasToolStripMenuItem.Text = "Alumnos";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // matricularAlumnoToolStripMenuItem
            // 
            this.matricularAlumnoToolStripMenuItem.Name = "matricularAlumnoToolStripMenuItem";
            this.matricularAlumnoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.matricularAlumnoToolStripMenuItem.Text = "Matricular Alumno";
            this.matricularAlumnoToolStripMenuItem.Click += new System.EventHandler(this.matricularAlumnoToolStripMenuItem_Click);
            // 
            // bajaDeAlumnoToolStripMenuItem
            // 
            this.bajaDeAlumnoToolStripMenuItem.Name = "bajaDeAlumnoToolStripMenuItem";
            this.bajaDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bajaDeAlumnoToolStripMenuItem.Text = "Baja de Alumno";
            this.bajaDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.bajaDeAlumnoToolStripMenuItem_Click);
            // 
            // inscribirAMateriaToolStripMenuItem
            // 
            this.inscribirAMateriaToolStripMenuItem.Name = "inscribirAMateriaToolStripMenuItem";
            this.inscribirAMateriaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.inscribirAMateriaToolStripMenuItem.Text = "Inscribir a Cursado";
            this.inscribirAMateriaToolStripMenuItem.Click += new System.EventHandler(this.inscribirAMateriaToolStripMenuItem_Click);
            // 
            // inscribirAFinalToolStripMenuItem
            // 
            this.inscribirAFinalToolStripMenuItem.Name = "inscribirAFinalToolStripMenuItem";
            this.inscribirAFinalToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.inscribirAFinalToolStripMenuItem.Text = "Inscribir a Final";
            this.inscribirAFinalToolStripMenuItem.Click += new System.EventHandler(this.inscribirAFinalToolStripMenuItem_Click);
            // 
            // registrarNotasToolStripMenuItem
            // 
            this.registrarNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notasParcialesToolStripMenuItem,
            this.finalesToolStripMenuItem});
            this.registrarNotasToolStripMenuItem.Name = "registrarNotasToolStripMenuItem";
            this.registrarNotasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.registrarNotasToolStripMenuItem.Text = "Registrar Notas";
            this.registrarNotasToolStripMenuItem.Click += new System.EventHandler(this.registrarNotasToolStripMenuItem_Click);
            // 
            // notasParcialesToolStripMenuItem
            // 
            this.notasParcialesToolStripMenuItem.Name = "notasParcialesToolStripMenuItem";
            this.notasParcialesToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.notasParcialesToolStripMenuItem.Text = "Parciales";
            this.notasParcialesToolStripMenuItem.Click += new System.EventHandler(this.notasParcialesToolStripMenuItem_Click);
            // 
            // finalesToolStripMenuItem
            // 
            this.finalesToolStripMenuItem.Name = "finalesToolStripMenuItem";
            this.finalesToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.finalesToolStripMenuItem.Text = "Finales";
            this.finalesToolStripMenuItem.Click += new System.EventHandler(this.finalesToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.verToolStripMenuItem.Text = "Estado de Materias";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem1,
            this.bajaDeProfesorToolStripMenuItem});

            
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bajasToolStripMenuItem.Text = "Profesores";
            // 
            // altasToolStripMenuItem1
            // 
            this.altasToolStripMenuItem1.Name = "altasToolStripMenuItem1";
            this.altasToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.altasToolStripMenuItem1.Text = "Altas";
            this.altasToolStripMenuItem1.Click += new System.EventHandler(this.altasToolStripMenuItem1_Click);
            // 
            // bajaDeProfesorToolStripMenuItem
            // 
            this.bajaDeProfesorToolStripMenuItem.Name = "bajaDeProfesorToolStripMenuItem";
            this.bajaDeProfesorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bajaDeProfesorToolStripMenuItem.Text = "Bajas";
            this.bajaDeProfesorToolStripMenuItem.Click += new System.EventHandler(this.bajaDeProfesorToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem1
            // 
            this.materiasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.bajaToolStripMenuItem,
            this.informaciónToolStripMenuItem2});
            
            this.materiasToolStripMenuItem1.Name = "materiasToolStripMenuItem1";
            this.materiasToolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.materiasToolStripMenuItem1.Text = "Materias";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.altaToolStripMenuItem1.Text = "Alta de Materia";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bajaToolStripMenuItem.Text = "Baja de Materia";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem2
            // 
            this.informaciónToolStripMenuItem2.Name = "informaciónToolStripMenuItem2";
            this.informaciónToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.informaciónToolStripMenuItem2.Text = "Información";
            this.informaciónToolStripMenuItem2.Click += new System.EventHandler(this.informaciónToolStripMenuItem2_Click);
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem1});
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.aulasToolStripMenuItem.Text = "Aulas";
            this.aulasToolStripMenuItem.Click += new System.EventHandler(this.aulasToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem1
            // 
            this.informaciónToolStripMenuItem1.Name = "informaciónToolStripMenuItem1";
            this.informaciónToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.informaciónToolStripMenuItem1.Text = "Información";
            this.informaciónToolStripMenuItem1.Click += new System.EventHandler(this.informaciónToolStripMenuItem1_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(829, 532);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Universidad";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricularAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirAMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasParcialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inscribirAFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaDeProfesorToolStripMenuItem;
    }
}

