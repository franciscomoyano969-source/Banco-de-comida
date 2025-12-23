namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            MATERIA_PRIMA mater = new MATERIA_PRIMA();
            mater.Show();
            Hide();
        }

        private void btnRotacionPersonal_Click(object sender, EventArgs e)
        {
            ROTACION_PERSONAL rota = new ROTACION_PERSONAL();
            rota.Show();
            Hide();
        }

        private void btnDistribucion_Click(object sender, EventArgs e)
        {
            DISTRIBUCION_ALIMENTOS dist = new DISTRIBUCION_ALIMENTOS();
            dist.Show();
            Hide();
        }

        private void btnSolicitudesInstituciones_Click(object sender, EventArgs e)
        {
            APOYO_INSTITUCIONES apoyo = new APOYO_INSTITUCIONES();
            apoyo.Show();
            Hide();
        }
    }
}
