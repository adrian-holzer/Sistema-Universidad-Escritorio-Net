namespace Presentacion
{
    partial class Registrar_Final_Materias_AlumnosInsc_Nota
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
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.Label();
            this.comboBoxNota = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(115, 39);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(119, 22);
            this.textBoxMatricula.TabIndex = 0;
            // 
            // textBoxAlumno
            // 
            this.textBoxAlumno.Location = new System.Drawing.Point(389, 37);
            this.textBoxAlumno.Name = "textBoxAlumno";
            this.textBoxAlumno.Size = new System.Drawing.Size(147, 22);
            this.textBoxAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrícula";
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alumno.Location = new System.Drawing.Point(301, 42);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(61, 17);
            this.Alumno.TabIndex = 3;
            this.Alumno.Text = "Alumno";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(389, 132);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(147, 22);
            this.textBoxEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // Nota
            // 
            this.Nota.AutoSize = true;
            this.Nota.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota.Location = new System.Drawing.Point(26, 133);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(40, 17);
            this.Nota.TabIndex = 6;
            this.Nota.Text = "Nota";
            // 
            // comboBoxNota
            // 
            this.comboBoxNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNota.FormattingEnabled = true;
            this.comboBoxNota.Items.AddRange(new object[] {
            "Ausente",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNota.Location = new System.Drawing.Point(113, 130);
            this.comboBoxNota.Name = "comboBoxNota";
            this.comboBoxNota.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNota.TabIndex = 7;
            this.comboBoxNota.SelectedIndexChanged += new System.EventHandler(this.comboBoxNota_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(229, 222);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 34);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(389, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 34);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Registrar_Final_Materias_AlumnosInsc_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(562, 294);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboBoxNota);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAlumno);
            this.Controls.Add(this.textBoxMatricula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registrar_Final_Materias_AlumnosInsc_Nota";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Registrar_Final_Materias_AlumnosInsc_Nota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.ComboBox comboBoxNota;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
    }
}