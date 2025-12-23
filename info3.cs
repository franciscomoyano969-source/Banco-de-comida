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
    public partial class info3 : Form
    {
        public info3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info4 if4 = new info4();
            if4.Show(this);
            this.Hide();
        }

        private void info3_Load(object sender, EventArgs e)
        {

        }
    }
}
