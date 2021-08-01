using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmModifCorr : Form
    {
        FrmModificarMateria frm = new FrmModificarMateria();
        public FrmModifCorr(FrmModificarMateria frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void FrmModifCorr_Load(object sender, EventArgs e)
        {
            comboBoxRequisito.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            bool validar = false;


            if (string.IsNullOrEmpty(comboBoxRequisito.Text))
            {
                errorProvider1.SetError(comboBoxRequisito,"No puede estar vacio");

            }
            else
            {
                validar = true;
            }
            return validar;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (Validar()==true)
            {
                frm.dataGridViewCorr.CurrentRow.Cells[2].Value = comboBoxRequisito.Text;

                this.Close();


            }

        }
    }
}
