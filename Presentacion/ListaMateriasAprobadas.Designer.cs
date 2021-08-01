namespace Presentacion
{
    partial class ListaMateriasAprobadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAprobadas = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TercerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerRecup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoRecup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprobadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAprobadas
            // 
            this.dataGridViewAprobadas.AllowUserToAddRows = false;
            this.dataGridViewAprobadas.AllowUserToDeleteRows = false;
            this.dataGridViewAprobadas.AllowUserToResizeColumns = false;
            this.dataGridViewAprobadas.AllowUserToResizeRows = false;
            this.dataGridViewAprobadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAprobadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Profesor,
            this.PrimerParcial,
            this.SegundoParcial,
            this.TercerParcial,
            this.PrimerRecup,
            this.SegundoRecup,
            this.NotaFinal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAprobadas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAprobadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAprobadas.Enabled = false;
            this.dataGridViewAprobadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewAprobadas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAprobadas.MultiSelect = false;
            this.dataGridViewAprobadas.Name = "dataGridViewAprobadas";
            this.dataGridViewAprobadas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAprobadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAprobadas.RowHeadersVisible = false;
            this.dataGridViewAprobadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAprobadas.RowTemplate.Height = 24;
            this.dataGridViewAprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAprobadas.Size = new System.Drawing.Size(1126, 450);
            this.dataGridViewAprobadas.TabIndex = 1;
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
            // PrimerParcial
            // 
            this.PrimerParcial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrimerParcial.HeaderText = "1º Parcial";
            this.PrimerParcial.Name = "PrimerParcial";
            this.PrimerParcial.ReadOnly = true;
            this.PrimerParcial.Width = 101;
            // 
            // SegundoParcial
            // 
            this.SegundoParcial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SegundoParcial.HeaderText = "2º Parcial";
            this.SegundoParcial.Name = "SegundoParcial";
            this.SegundoParcial.ReadOnly = true;
            this.SegundoParcial.Width = 101;
            // 
            // TercerParcial
            // 
            this.TercerParcial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TercerParcial.HeaderText = "3º Parcial";
            this.TercerParcial.Name = "TercerParcial";
            this.TercerParcial.ReadOnly = true;
            this.TercerParcial.Width = 101;
            // 
            // PrimerRecup
            // 
            this.PrimerRecup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrimerRecup.HeaderText = "1º Recuperatorio";
            this.PrimerRecup.Name = "PrimerRecup";
            this.PrimerRecup.ReadOnly = true;
            this.PrimerRecup.Width = 149;
            // 
            // SegundoRecup
            // 
            this.SegundoRecup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SegundoRecup.HeaderText = "2º Recuperatorio";
            this.SegundoRecup.Name = "SegundoRecup";
            this.SegundoRecup.ReadOnly = true;
            this.SegundoRecup.Width = 149;
            // 
            // NotaFinal
            // 
            this.NotaFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NotaFinal.HeaderText = "Nota Final";
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.ReadOnly = true;
            this.NotaFinal.Width = 105;
            // 
            // ListaMateriasAprobadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 450);
            this.Controls.Add(this.dataGridViewAprobadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaMateriasAprobadas";
            this.ShowIcon = false;
            this.Text = "Materias Aprobadas";
            this.Load += new System.EventHandler(this.ListaMateriasAprobadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprobadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAprobadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TercerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerRecup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoRecup;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
    }
}