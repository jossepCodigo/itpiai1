namespace Form_Usuario_Contrasenia
{
    partial class Telefono
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
            this.lstFono = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pBxAgregarTF = new System.Windows.Forms.PictureBox();
            this.pBxBorrarTF = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxAgregarTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxBorrarTF)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFono
            // 
            this.lstFono.FormattingEnabled = true;
            this.lstFono.Location = new System.Drawing.Point(6, 12);
            this.lstFono.Name = "lstFono";
            this.lstFono.Size = new System.Drawing.Size(242, 225);
            this.lstFono.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pBxAgregarTF);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pBxBorrarTF);
            this.panel1.Controls.Add(this.lstFono);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(7, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 298);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFONO";
            // 
            // pBxAgregarTF
            // 
            this.pBxAgregarTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxAgregarTF.Image = global::Form_Usuario_Contrasenia.Properties.Resources.cloud_computing_1;
            this.pBxAgregarTF.Location = new System.Drawing.Point(254, 180);
            this.pBxAgregarTF.MaximumSize = new System.Drawing.Size(100, 106);
            this.pBxAgregarTF.MinimumSize = new System.Drawing.Size(100, 106);
            this.pBxAgregarTF.Name = "pBxAgregarTF";
            this.pBxAgregarTF.Size = new System.Drawing.Size(100, 106);
            this.pBxAgregarTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxAgregarTF.TabIndex = 9;
            this.pBxAgregarTF.TabStop = false;
            this.pBxAgregarTF.Click += new System.EventHandler(this.pBxAgregarTF_Click);
            // 
            // pBxBorrarTF
            // 
            this.pBxBorrarTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxBorrarTF.Image = global::Form_Usuario_Contrasenia.Properties.Resources.cancel1;
            this.pBxBorrarTF.Location = new System.Drawing.Point(254, 39);
            this.pBxBorrarTF.MaximumSize = new System.Drawing.Size(100, 106);
            this.pBxBorrarTF.MinimumSize = new System.Drawing.Size(100, 106);
            this.pBxBorrarTF.Name = "pBxBorrarTF";
            this.pBxBorrarTF.Size = new System.Drawing.Size(100, 106);
            this.pBxBorrarTF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxBorrarTF.TabIndex = 8;
            this.pBxBorrarTF.TabStop = false;
            this.pBxBorrarTF.Click += new System.EventHandler(this.pBxBorrarTF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(273, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "BORRAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "AGREGAR";
            // 
            // Telefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(381, 365);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Telefono";
            this.Text = "Telefono";
            this.Load += new System.EventHandler(this.Telefono_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxAgregarTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxBorrarTF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFono;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pBxAgregarTF;
        private System.Windows.Forms.PictureBox pBxBorrarTF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}