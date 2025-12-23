namespace WinFormsApp3
{
    partial class ROTACION_PERSONAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROTACION_PERSONAL));
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
            label1.Location = new Point(151, 25);
            label1.Name = "label1";
            label1.Size = new Size(204, 22);
            label1.TabIndex = 0;
            label1.Text = "Rotación de Personal\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(40, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 107);
            label2.Name = "label2";
            label2.Size = new Size(206, 80);
            label2.TabIndex = 3;
            label2.Text = "La rotación del personal\r\npermite que todos colaboren\r\nen distintas tareas, fortaleciendo\r\nel trabajo en equipo y la \r\nresponsabilidad copartida.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 231);
            label3.Name = "label3";
            label3.Size = new Size(436, 18);
            label3.TabIndex = 4;
            label3.Text = "El compromiso de las persona hace posible el cambio.\r\n";
            // 
            // pctVolver
            // 
            pctVolver.BackColor = Color.Transparent;
            pctVolver.BackgroundImage = (Image)resources.GetObject("pctVolver.BackgroundImage");
            pctVolver.BackgroundImageLayout = ImageLayout.Stretch;
            pctVolver.Location = new Point(382, 12);
            pctVolver.Name = "pctVolver";
            pctVolver.Size = new Size(70, 57);
            pctVolver.TabIndex = 5;
            pctVolver.TabStop = false;
            pctVolver.Click += pictureBox3_Click;
            pctVolver.MouseEnter += pctVolver_MouseEnter_1;
            pctVolver.MouseLeave += pctVolver_MouseLeave_1;
            // 
            // ROTACION_PERSONAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 284);
            Controls.Add(pctVolver);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ROTACION_PERSONAL";
            Text = "ROTACION_PERSONAL";
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