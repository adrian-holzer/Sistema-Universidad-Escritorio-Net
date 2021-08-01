namespace Presentacion
{
    partial class Info_Curso_Materias
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
            this.dataGridViewMaterias_Curso = new System.Windows.Forms.DataGridView();
            this.Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias_Curso)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaterias_Curso
            // 
            this.dataGridViewMaterias_Curso.AllowUserToAddRows = false;
            this.dataGridViewMaterias_Curso.AllowUserToDeleteRows = false;
            this.dataGridViewMaterias_Curso.AllowUserToOrderColumns = true;
            this.dataGridViewMaterias_Curso.AllowUserToResizeColumns = false;
            this.dataGridViewMaterias_Curso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMaterias_Curso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewMaterias_Curso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaterias_Curso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMaterias_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterias_Curso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materias,
            this.Profesor,
            this.Correlativas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMaterias_Curso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMaterias_Curso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterias_Curso.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterias_Curso.Name = "dataGridViewMaterias_Curso";
            this.dataGridViewMaterias_Curso.ReadOnly = true;
            this.dataGridViewMaterias_Curso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewMaterias_Curso.RowHeadersVisible = false;
            this.dataGridViewMaterias_Curso.RowTemplate.Height = 24;
            this.dataGridViewMaterias_Curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterias_Curso.Size = new System.Drawing.Size(1007, 204);
            this.dataGridViewMaterias_Curso.TabIndex = 0;
            this.dataGridViewMaterias_Curso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_Curso_CellContentClick);
            // 
            // Materias
            // 
            this.Materias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Materias.HeaderText = "Materias";
            this.Materias.Name = "Materias";
            this.Materias.ReadOnly = true;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // Correlativas
            // 
            this.Correlativas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correlativas.HeaderText = "Correlativas";
            this.Correlativas.Name = "Correlativas";
            this.Correlativas.ReadOnly = true;
            this.Correlativas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Info_Curso_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1007, 204);
            this.Controls.Add(this.dataGridViewMaterias_Curso);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info_Curso_Materias";
            this.ShowIcon = false;
            this.Text = "Materias del Curso";
            this.Load += new System.EventHandler(this.Info_Curso_Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias_Curso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaterias_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativas;
    }
}