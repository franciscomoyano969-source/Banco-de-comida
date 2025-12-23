namespace WinFormsApp3
{
    partial class APOYO_INSTITUCIONES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APOYO_INSTITUCIONES));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pctVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVolver).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 27);
            label1.Name = "label1";
            label1.Size = new Size(205, 22);
            label1.TabIndex = 0;
            label1.Text = "Apoyo a Instituciones";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(39, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 81);
            label2.Name = "label2";
            label2.Size = new Size(254, 112);
            label2.TabIndex = 3;
            label2.Text = "Las instituciones colaboradoras brindan\r\napoyo fundamental para fortalecer la \r\ndistribución de alimentos y recursos.\r\n\r\nLa cooperación interinstitucional\r\namplia el alcance de la ayuda \r\nsocial.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 217);
            label3.Name = "label3";
            label3.Size = new Size(336, 18);
            label3.TabIndex = 4;
            label3.Text = "Unidos logramos ayudar a más personas.";
            // 
            // pctVolver
            // 
            pctVolver.BackColor = Color.Transparent;
            pctVolver.Image = (Image)resources.GetObject("pctVolver.Image");
            pctVolver.Location = new Point(395, 12);
            pctVolver.Name = "pctVolver";
            pctVolver.Size = new Size(64, 50);
            pctVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVolver.TabIndex = 5;
            pctVolver.TabStop = false;
            pctVolver.Click += pctVolver_Click;
            pctVolver.MouseEnter += pctVolver_MouseEnter;
            pctVolver.MouseLeave += pctVolver_MouseLeave;
            // 
            // APOYO_INSTITUCIONES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(471, 279);
            Controls.Add(pctVolver);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "APOYO_INSTITUCIONES";
            Text = "APOYO_INSTITUCIONES";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox pctVolver;
    }
}