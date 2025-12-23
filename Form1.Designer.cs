namespace Banco_de_comida
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtingresar = new System.Windows.Forms.TextBox();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblingnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btningresar
            // 
            this.btningresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Image = ((System.Drawing.Image)(resources.GetObject("btningresar.Image")));
            this.btningresar.Location = new System.Drawing.Point(369, 319);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(100, 31);
            this.btningresar.TabIndex = 1;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtingresar
            // 
            this.txtingresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtingresar.Location = new System.Drawing.Point(310, 276);
            this.txtingresar.Name = "txtingresar";
            this.txtingresar.Size = new System.Drawing.Size(207, 20);
            this.txtingresar.TabIndex = 2;
            this.txtingresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtingresar.TextChanged += new System.EventHandler(this.txtingresar_TextChanged);
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.BackColor = System.Drawing.Color.Transparent;
            this.lblinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblinicio.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.Location = new System.Drawing.Point(252, 86);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(314, 82);
            this.lblinicio.TabIndex = 3;
            this.lblinicio.Text = "¡Banco de Comida \r\n     comunitario!";
            // 
            // lblingnombre
            // 
            this.lblingnombre.AutoSize = true;
            this.lblingnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblingnombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblingnombre.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingnombre.Location = new System.Drawing.Point(291, 195);
            this.lblingnombre.Name = "lblingnombre";
            this.lblingnombre.Size = new System.Drawing.Size(238, 33);
            this.lblingnombre.TabIndex = 4;
            this.lblingnombre.Text = "Ingrese su nombre:";
            this.lblingnombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblingnombre);
            this.Controls.Add(this.lblinicio);
            this.Controls.Add(this.txtingresar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtingresar;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblingnombre;
    }
}

