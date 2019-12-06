namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.carro1 = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).BeginInit();
            this.SuspendLayout();
            // 
            // carro1
            // 
            this.carro1.BackColor = System.Drawing.Color.Transparent;
            this.carro1.Image = global::WindowsFormsApplication1.Properties.Resources.carritouno_;
            this.carro1.Location = new System.Drawing.Point(3, 414);
            this.carro1.Margin = new System.Windows.Forms.Padding(4);
            this.carro1.Name = "carro1";
            this.carro1.Size = new System.Drawing.Size(45, 90);
            this.carro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.carro1.TabIndex = 0;
            this.carro1.TabStop = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(16, 11);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(19, 18);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.carretera;
            this.ClientSize = new System.Drawing.Size(197, 517);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.carro1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carro1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

