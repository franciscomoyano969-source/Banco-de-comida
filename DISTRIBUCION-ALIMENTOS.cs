using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class DISTRIBUCION_ALIMENTOS : Form
    {
        public DISTRIBUCION_ALIMENTOS()
        {
            InitializeComponent();
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void pctVolver_MouseEnter(object sender, EventArgs e)
        {
            pctVolver.BackColor = Color.LightCyan;
        }

        private void pctVolver_MouseLeave(object sender, EventArgs e)
        {
            pctVolver.BackColor = Color.LightCyan;
        }
    }
}
