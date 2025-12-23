using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MATERIA_PRIMA : Form
    {
        public MATERIA_PRIMA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Hide();
        }

        private void MATERIA_PRIMA_Load(object sender, EventArgs e)
        {
            pctVolver.Enabled = true;
            pctVolver.Cursor = Cursors.Hand;

        }

        private void MATERIA_PRIMA_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pctVolver_MouseEnter(object sender, EventArgs e)
        {
            pctVolver.BackColor = Color.LightCyan;
        }

        private void pctVolver_MouseLeave(object sender, EventArgs e)
        {
            pctVolver.BackColor = Color.Transparent;
        }
    }
}
