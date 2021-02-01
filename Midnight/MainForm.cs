using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midnight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbxOpcoesP.Text = "ADICIONAR PRODUTO";
        }

        private void ckbTipoProduto_CheckedChanged(object sender, EventArgs e)
        {
            cbxTipoProduto.Visible = false;
            txtTipoProduto.Visible = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cbxOpcoesE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOpcoesE.SelectedIndex == 1) {
                Form f1 = FindForm();
                EditEForm f2 = new EditEForm();
                f2.Show();
                f1.Hide();
            }
        }

        private void cbxOpcoesP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOpcoesP.SelectedIndex == 1) {
                Form f1 = FindForm();
                EditPForm f2 = new EditPForm();
                f2.Show();
                f1.Hide();
            }
        }
    }
}
