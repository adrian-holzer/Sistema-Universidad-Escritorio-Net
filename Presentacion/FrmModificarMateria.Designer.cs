namespace Presentacion
{
    partial class FrmModificarMateria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCorr = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requisito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.textIDMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombreMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textProfesor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCorr
            // 
            this.dataGridViewCorr.AllowUserToAddRows = false;
            this.dataGridViewCorr.AllowUserToDeleteRows = false;
            this.dataGridViewCorr.AllowUserToResizeColumns = false;
            this.dataGridViewCorr.AllowUserToResizeRows = false;
            this.dataGridViewCorr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCorr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCorr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Correlativa,
            this.Requisito,
            this.Editar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCorr.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCorr.Location = new System.Drawing.Point(41, 202);
            this.dataGridViewCorr.Name = "dataGridViewCorr";
            this.dataGridViewCorr.ReadOnly = true;
            this.dataGridViewCorr.RowHeadersVisible = false;
            this.dataGridViewCorr.RowTemplate.Height = 24;
            this.dataGridViewCorr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCorr.Size = new System.Drawing.Size(780, 235);
            this.dataGridViewCorr.TabIndex = 0;
            this.dataGridViewCorr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCorr_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Correlativa
            // 
            this.Correlativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correlativa.HeaderText = "Correlativa";
            this.Correlativa.Name = "Correlativa";
            this.Correlativa.ReadOnly = true;
            // 
            // Requisito
            // 
            this.Requisito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Requisito.HeaderText = "Requisito";
            this.Requisito.Name = "Requisito";
            this.Requisito.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 51;
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(636, 126);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(185, 24);
            this.comboBoxProfesor.TabIndex = 2;
            this.comboBoxProfesor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfesor_SelectedIndexChanged);
            // 
            // textIDMateria
            // 
            this.textIDMateria.Enabled = false;
            this.textIDMateria.Location = new System.Drawing.Point(200, 49);
            this.textIDMateria.Name = "textIDMateria";
            this.textIDMateria.Size = new System.Drawing.Size(162, 22);
            this.textIDMateria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asignar Nuevo Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Materia";
            // 
            // textNombreMateria
            // 
            this.textNombreMateria.Location = new System.Drawing.Point(636, 49);
            this.textNombreMateria.Name = "textNombreMateria";
            this.textNombreMateria.Size = new System.Drawing.Size(185, 22);
            this.textNombreMateria.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Profesor";
            // 
            // textProfesor
            // 
            this.textProfesor.Enabled = false;
            this.textProfesor.Location = new System.Drawing.Point(200, 126);
            this.textProfesor.Name = "textProfesor";
            this.textProfesor.Size = new System.Drawing.Size(162, 22);
            this.textProfesor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Modificar Materia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmModificarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(859, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNombreMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIDMateria);
            this.Controls.Add(this.comboBoxProfesor);
            this.Controls.Add(this.dataGridViewCorr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarMateria";
            this.ShowIcon = false;
            this.Text = "Modificacion Materia";
            this.Load += new System.EventHandler(this.FrmModificarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView dataGridViewCorr;
        internal System.Windows.Forms.ComboBox comboBoxProfesor;
        internal System.Windows.Forms.TextBox textIDMateria;
        internal System.Windows.Forms.TextBox textNombreMateria;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox textProfesor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requisito;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}