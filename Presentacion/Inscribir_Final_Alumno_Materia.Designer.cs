namespace Presentacion
{
    partial class Inscribir_Final_Alumno_Materia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNombrAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFinal = new System.Windows.Forms.DataGridView();
            this.lbldisponibles = new System.Windows.Forms.Label();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(172, 102);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(100, 23);
            this.textBoxMatricula.TabIndex = 0;
            // 
            // textBoxNombrAlumno
            // 
            this.textBoxNombrAlumno.Location = new System.Drawing.Point(502, 106);
            this.textBoxNombrAlumno.Name = "textBoxNombrAlumno";
            this.textBoxNombrAlumno.Size = new System.Drawing.Size(202, 23);
            this.textBoxNombrAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inscripción a Final";
            // 
            // dataGridViewFinal
            // 
            this.dataGridViewFinal.AllowUserToAddRows = false;
            this.dataGridViewFinal.AllowUserToDeleteRows = false;
            this.dataGridViewFinal.AllowUserToResizeColumns = false;
            this.dataGridViewFinal.AllowUserToResizeRows = false;
            this.dataGridViewFinal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMateria,
            this.Materia,
            this.Profesor,
            this.Inscripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFinal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFinal.Location = new System.Drawing.Point(109, 197);
            this.dataGridViewFinal.MultiSelect = false;
            this.dataGridViewFinal.Name = "dataGridViewFinal";
            this.dataGridViewFinal.ReadOnly = true;
            this.dataGridViewFinal.RowHeadersVisible = false;
            this.dataGridViewFinal.RowTemplate.Height = 24;
            this.dataGridViewFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFinal.Size = new System.Drawing.Size(649, 226);
            this.dataGridViewFinal.TabIndex = 5;
            this.dataGridViewFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinal_CellClick);
            this.dataGridViewFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinal_CellContentClick);
            this.dataGridViewFinal.SelectionChanged += new System.EventHandler(this.dataGridViewFinal_SelectionChanged);
            this.dataGridViewFinal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFinal_MouseClick);
            // 
            // lbldisponibles
            // 
            this.lbldisponibles.AutoSize = true;
            this.lbldisponibles.Location = new System.Drawing.Point(317, 294);
            this.lbldisponibles.Name = "lbldisponibles";
            this.lbldisponibles.Size = new System.Drawing.Size(290, 17);
            this.lbldisponibles.TabIndex = 6;
            this.lbldisponibles.Text = "No hay Materias Disponibles para Inscribir";
            // 
            // btnComprobante
            // 
            this.btnComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.Location = new System.Drawing.Point(586, 462);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(172, 35);
            this.btnComprobante.TabIndex = 7;
            this.btnComprobante.Text = "Generar Comprobante";
            this.btnComprobante.UseVisualStyleBackColor = true;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(396, 460);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(123, 35);
            this.btnInscribir.TabIndex = 8;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(198, 460);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(123, 35);
            this.btnAnular.TabIndex = 9;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // IDMateria
            // 
            this.IDMateria.HeaderText = "IDMateria";
            this.IDMateria.Name = "IDMateria";
            this.IDMateria.ReadOnly = true;
            this.IDMateria.Visible = false;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // Inscripcion
            // 
            this.Inscripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inscripcion.HeaderText = "Inscripción";
            this.Inscripcion.Name = "Inscripcion";
            this.Inscripcion.ReadOnly = true;
            this.Inscripcion.Width = 111;
            // 
            // Inscribir_Final_Alumno_Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(837, 509);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.lbldisponibles);
            this.Controls.Add(this.dataGridViewFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombrAlumno);
            this.Controls.Add(this.textBoxMatricula);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inscribir_Final_Alumno_Materia";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Incribir_Final_Alumno_Materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxNombrAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFinal;
        private System.Windows.Forms.Label lbldisponibles;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscripcion;
    }
}