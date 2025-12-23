namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            btnMateriaPrima = new Button();
            pictureBox2 = new PictureBox();
            btnRotacionPersonal = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            btnDistribucion = new Button();
            pictureBox4 = new PictureBox();
            btnSolicitudesInstituciones = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 37);
            label1.Name = "label1";
            label1.Size = new Size(338, 22);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido al Panel Administrativo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 59);
            label2.Name = "label2";
            label2.Size = new Size(290, 40);
            label2.TabIndex = 1;
            label2.Text = "Seleccione una opción para administrar y revisar la\r\ndistribución de alimentos y la gestion del personal.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(btnMateriaPrima);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(btnRotacionPersonal);
            flowLayoutPanel1.Location = new Point(71, 134);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(245, 172);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnMateriaPrima
            // 
            btnMateriaPrima.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMateriaPrima.Location = new Point(85, 3);
            btnMateriaPrima.Name = "btnMateriaPrima";
            btnMateriaPrima.Size = new Size(154, 76);
            btnMateriaPrima.TabIndex = 1;
            btnMateriaPrima.Text = "Materia Prima";
            btnMateriaPrima.UseVisualStyleBackColor = true;
            btnMateriaPrima.Click += btnMateriaPrima_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnRotacionPersonal
            // 
            btnRotacionPersonal.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRotacionPersonal.Location = new Point(85, 85);
            btnRotacionPersonal.Name = "btnRotacionPersonal";
            btnRotacionPersonal.Size = new Size(154, 76);
            btnRotacionPersonal.TabIndex = 3;
            btnRotacionPersonal.Text = "Rotación de Personal";
            btnRotacionPersonal.UseVisualStyleBackColor = true;
            btnRotacionPersonal.Click += btnRotacionPersonal_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Controls.Add(btnDistribucion);
            flowLayoutPanel2.Controls.Add(pictureBox4);
            flowLayoutPanel2.Controls.Add(btnSolicitudesInstituciones);
            flowLayoutPanel2.Location = new Point(331, 134);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(248, 172);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.CadetBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btnDistribucion
            // 
            btnDistribucion.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDistribucion.Location = new Point(85, 3);
            btnDistribucion.Name = "btnDistribucion";
            btnDistribucion.Size = new Size(154, 76);
            btnDistribucion.TabIndex = 1;
            btnDistribucion.Text = "Distribución";
            btnDistribucion.UseVisualStyleBackColor = true;
            btnDistribucion.Click += btnDistribucion_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.CadetBlue;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 85);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(76, 76);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btnSolicitudesInstituciones
            // 
            btnSolicitudesInstituciones.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolicitudesInstituciones.Location = new Point(85, 85);
            btnSolicitudesInstituciones.Name = "btnSolicitudesInstituciones";
            btnSolicitudesInstituciones.Size = new Size(154, 76);
            btnSolicitudesInstituciones.TabIndex = 3;
            btnSolicitudesInstituciones.Text = "Solicitudes a Instituciones";
            btnSolicitudesInstituciones.UseVisualStyleBackColor = true;
            btnSolicitudesInstituciones.Click += btnSolicitudesInstituciones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(651, 367);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Button btnMateriaPrima;
        private PictureBox pictureBox2;
        private Button btnRotacionPersonal;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox3;
        private Button btnDistribucion;
        private PictureBox pictureBox4;
        private Button btnSolicitudesInstituciones;
    }
}
