using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ROTACION_PERSONAL : Form
    {
        public ROTACION_PERSONAL()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void ROTACION_PERSONAL_Label(object sender, EventArgs e)
        {
            pctVolver.Enabled = true;
            pctVolver.Cursor = Cursors.Hand;

        }

        private void ROTACION_PERSONAL_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pctVolver_MouseEnter_1(object sender, EventArgs e)
        {
            pctVolver.BackColor = Color.LightCyan;
        }

        private void pctVolver_MouseLeave_1(object sender, EventArgs e)
        {
            pctVolver.BackColor = Color.Transparent;
        }
    }

}
