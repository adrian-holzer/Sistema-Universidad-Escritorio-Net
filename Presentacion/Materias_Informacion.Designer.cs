namespace Presentacion
{
    partial class Materias_Informacion
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
            this.dataGridViewMateriasInfo = new System.Windows.Forms.DataGridView();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlumnosCursa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxBuscarMat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriasInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMateriasInfo
            // 
            this.dataGridViewMateriasInfo.AllowUserToAddRows = false;
            this.dataGridViewMateriasInfo.AllowUserToDeleteRows = false;
            this.dataGridViewMateriasInfo.AllowUserToResizeColumns = false;
            this.dataGridViewMateriasInfo.AllowUserToResizeRows = false;
            this.dataGridViewMateriasInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMateriasInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMateriasInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMateriasInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriasInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateria,
            this.Nombre,
            this.Profesor,
            this.Curso,
            this.Aula,
            this.Correlativas,
            this.AlumnosCursa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMateriasInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMateriasInfo.Location = new System.Drawing.Point(22, 114);
            this.dataGridViewMateriasInfo.MultiSelect = false;
            this.dataGridViewMateriasInfo.Name = "dataGridViewMateriasInfo";
            this.dataGridViewMateriasInfo.ReadOnly = true;
            this.dataGridViewMateriasInfo.RowHeadersVisible = false;
            this.dataGridViewMateriasInfo.RowTemplate.Height = 24;
            this.dataGridViewMateriasInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMateriasInfo.Size = new System.Drawing.Size(1104, 233);
            this.dataGridViewMateriasInfo.TabIndex = 0;
            this.dataGridViewMateriasInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMateriasInfo_CellContentClick);
            // 
            // IdMateria
            // 
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            this.IdMateria.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Curso.Width = 52;
            // 
            // Aula
            // 
            this.Aula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            this.Aula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Aula.Width = 45;
            // 
            // Correlativas
            // 
            this.Correlativas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correlativas.HeaderText = "Correlativas";
            this.Correlativas.Name = "Correlativas";
            this.Correlativas.ReadOnly = true;
            this.Correlativas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AlumnosCursa
            // 
            this.AlumnosCursa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AlumnosCursa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlumnosCursa.HeaderText = "Alumnos Cursando";
            this.AlumnosCursa.Name = "AlumnosCursa";
            this.AlumnosCursa.ReadOnly = true;
            this.AlumnosCursa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlumnosCursa.Width = 127;
            // 
            // textBoxBuscarMat
            // 
            this.textBoxBuscarMat.Location = new System.Drawing.Point(215, 55);
            this.textBoxBuscarMat.Name = "textBoxBuscarMat";
            this.textBoxBuscarMat.Size = new System.Drawing.Size(185, 22);
            this.textBoxBuscarMat.TabIndex = 1;
            this.textBoxBuscarMat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // Materias_Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1184, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscarMat);
            this.Controls.Add(this.dataGridViewMateriasInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Materias_Informacion";
            this.ShowIcon = false;
            this.Text = "Información Materias";
            this.Load += new System.EventHandler(this.Materias_Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriasInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMateriasInfo;
        private System.Windows.Forms.TextBox textBoxBuscarMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativas;
        private System.Windows.Forms.DataGridViewButtonColumn AlumnosCursa;
    }
}