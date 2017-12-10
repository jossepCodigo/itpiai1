namespace Form_Usuario_Contrasenia
{
    partial class Usuario_Contrasenia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBxCancelarUC = new System.Windows.Forms.PictureBox();
            this.pBxIngresarUC = new System.Windows.Forms.PictureBox();
            this.tBxContraseniaUC = new System.Windows.Forms.TextBox();
            this.tBxUsuarioUC = new System.Windows.Forms.TextBox();
            this.btnSalirUC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxCancelarUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxIngresarUC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBxCancelarUC);
            this.panel1.Controls.Add(this.pBxIngresarUC);
            this.panel1.Controls.Add(this.tBxContraseniaUC);
            this.panel1.Controls.Add(this.tBxUsuarioUC);
            this.panel1.Location = new System.Drawing.Point(1, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 149);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(185, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "USUARIO";
            // 
            // pBxCancelarUC
            // 
            this.pBxCancelarUC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxCancelarUC.Image = global::Form_Usuario_Contrasenia.Properties.Resources.cancel;
            this.pBxCancelarUC.Location = new System.Drawing.Point(359, 19);
            this.pBxCancelarUC.MaximumSize = new System.Drawing.Size(100, 106);
            this.pBxCancelarUC.MinimumSize = new System.Drawing.Size(100, 106);
            this.pBxCancelarUC.Name = "pBxCancelarUC";
            this.pBxCancelarUC.Size = new System.Drawing.Size(100, 106);
            this.pBxCancelarUC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxCancelarUC.TabIndex = 3;
            this.pBxCancelarUC.TabStop = false;
            // 
            // pBxIngresarUC
            // 
            this.pBxIngresarUC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxIngresarUC.Image = global::Form_Usuario_Contrasenia.Properties.Resources.password;
            this.pBxIngresarUC.Location = new System.Drawing.Point(11, 21);
            this.pBxIngresarUC.MaximumSize = new System.Drawing.Size(100, 106);
            this.pBxIngresarUC.MinimumSize = new System.Drawing.Size(100, 106);
            this.pBxIngresarUC.Name = "pBxIngresarUC";
            this.pBxIngresarUC.Size = new System.Drawing.Size(100, 106);
            this.pBxIngresarUC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxIngresarUC.TabIndex = 2;
            this.pBxIngresarUC.TabStop = false;
            this.pBxIngresarUC.Click += new System.EventHandler(this.pBxIngresar_Click);
            // 
            // tBxContraseniaUC
            // 
            this.tBxContraseniaUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxContraseniaUC.Location = new System.Drawing.Point(118, 100);
            this.tBxContraseniaUC.Multiline = true;
            this.tBxContraseniaUC.Name = "tBxContraseniaUC";
            this.tBxContraseniaUC.PasswordChar = '*';
            this.tBxContraseniaUC.Size = new System.Drawing.Size(232, 27);
            this.tBxContraseniaUC.TabIndex = 1;
            this.tBxContraseniaUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBxContraseniaUC_KeyPress);
            // 
            // tBxUsuarioUC
            // 
            this.tBxUsuarioUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxUsuarioUC.Location = new System.Drawing.Point(118, 38);
            this.tBxUsuarioUC.Multiline = true;
            this.tBxUsuarioUC.Name = "tBxUsuarioUC";
            this.tBxUsuarioUC.Size = new System.Drawing.Size(232, 27);
            this.tBxUsuarioUC.TabIndex = 0;
            // 
            // btnSalirUC
            // 
            this.btnSalirUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalirUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalirUC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalirUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirUC.ForeColor = System.Drawing.Color.White;
            this.btnSalirUC.Location = new System.Drawing.Point(395, 205);
            this.btnSalirUC.Name = "btnSalirUC";
            this.btnSalirUC.Size = new System.Drawing.Size(75, 34);
            this.btnSalirUC.TabIndex = 2;
            this.btnSalirUC.Text = "SALIR";
            this.btnSalirUC.UseVisualStyleBackColor = false;
            this.btnSalirUC.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(122, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 42);
            this.label6.TabIndex = 4;
            this.label6.Text = "\" I.T.P.I.A.I \"";
            // 
            // Usuario_Contrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(471, 242);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalirUC);
            this.Controls.Add(this.panel1);
            this.Name = "Usuario_Contrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIO_CONTRASEÑA";
            this.Load += new System.EventHandler(this.Usuario_Contrasenia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxCancelarUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxIngresarUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBxCancelarUC;
        private System.Windows.Forms.PictureBox pBxIngresarUC;
        private System.Windows.Forms.TextBox tBxContraseniaUC;
        private System.Windows.Forms.TextBox tBxUsuarioUC;
        private System.Windows.Forms.Button btnSalirUC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

