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
    public partial class info2 : Form
    {
        public info2()
        {
            InitializeComponent();
        }

        private void tbtsiguiente2_Click(object sender, EventArgs e)
        {
            info3 if3 = new info3();
            if3.Show(this);
            this.Hide();
        }
    }
}
