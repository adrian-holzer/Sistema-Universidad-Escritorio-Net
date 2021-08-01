namespace Presentacion
{
    partial class ListaMateriasRegulares
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
            this.dataGridViewRegulares = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TercerParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerRecup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoRecup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegulares)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRegulares
            // 
            this.dataGridViewRegulares.AllowUserToAddRows = false;
            this.dataGridViewRegulares.AllowUserToDeleteRows = false;
            this.dataGridViewRegulares.AllowUserToResizeColumns = false;
            this.dataGridViewRegulares.AllowUserToResizeRows = false;
            this.dataGridViewRegulares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegulares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRegulares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Profesor,
            this.PrimerParcial,
            this.SegundoParcial,
            this.TercerParcial,
            this.PrimerRecup,
            this.SegundoRecup});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegulares.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegulares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRegulares.Enabled = false;
            this.dataGridViewRegulares.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewRegulares.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRegulares.MultiSelect = false;
            this.dataGridViewRegulares.Name = "dataGridViewRegulares";
            this.dataGridViewRegulares.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegulares.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRegulares.RowHeadersVisible = false;
            this.dataGridViewRegulares.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRegulares.RowTemplate.Height = 24;
            this.dataGridViewRegulares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegulares.Size = new System.Drawing.Size(1057, 462);
            this.dataGridViewRegulares.TabIndex = 0;
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
            // ListaMateriasRegulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1057, 462);
            this.Controls.Add(this.dataGridViewRegulares);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaMateriasRegulares";
            this.ShowIcon = false;
            this.Text = "Materias Regulares";
            this.Load += new System.EventHandler(this.ListaMateriasRegulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegulares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRegulares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TercerParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerRecup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoRecup;
    }
}