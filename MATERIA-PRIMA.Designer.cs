namespace WinFormsApp3
{
    partial class MATERIA_PRIMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MATERIA_PRIMA));
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            pctVolver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVolver).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 20);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 1;
            label2.Text = "Materia Prima";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(120, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 75);
            label1.Name = "label1";
            label1.Size = new Size(247, 144);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 231);
            label3.Name = "label3";
            label3.Size = new Size(376, 18);
            label3.TabIndex = 5;
            label3.Text = "Cuidar los alimentos es cuidar a la comunidad.\r\n";
            // 
            // pctVolver
            // 
            pctVolver.BackColor = Color.Transparent;
            pctVolver.Image = (Image)resources.GetObject("pctVolver.Image");
            pctVolver.Location = new Point(380, 6);
            pctVolver.Name = "pctVolver";
            pctVolver.Size = new Size(73, 60);
            pctVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVolver.TabIndex = 6;
            pctVolver.TabStop = false;
            pctVolver.Click += pctVolver_Click;
            pctVolver.MouseEnter += pctVolver_MouseEnter;
            pctVolver.MouseLeave += pctVolver_MouseLeave;
            // 
            // MATERIA_PRIMA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(465, 279);
            Controls.Add(pctVolver);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Name = "MATERIA_PRIMA";
            Text = "MATERIA_PRIMA";
            Load += MATERIA_PRIMA_Load;
            MouseEnter += MATERIA_PRIMA_MouseEnter;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private PictureBox pctVolver;
    }
}