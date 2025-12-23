using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_comida
{
    public partial class info1 : Form
    {
        public info1()
        {
            InitializeComponent();
        }

        private void tbtsiguiente1_Click(object sender, EventArgs e)
        {
            info2 if2 = new info2();
            if2.Show(this);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
