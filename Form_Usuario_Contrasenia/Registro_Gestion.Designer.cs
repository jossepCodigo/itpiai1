namespace Form_Usuario_Contrasenia
{
    partial class Registro_Gestion
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbtSalir = new System.Windows.Forms.PictureBox();
            this.pbtGuardar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxModalid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txAño = new System.Windows.Forms.TextBox();
            this.txNum = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtGuardar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btCancel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pbtSalir);
            this.panel4.Controls.Add(this.pbtGuardar);
            this.panel4.Location = new System.Drawing.Point(571, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 411);
            this.panel4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "ELIMINAR";
            // 
            // btCancel
            // 
            this.btCancel.Image = global::Form_Usuario_Contrasenia.Properties.Resources.cancel;
            this.btCancel.Location = new System.Drawing.Point(17, 37);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 86);
            this.btCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCancel.TabIndex = 9;
            this.btCancel.TabStop = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "GUARDAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "SALIR";
            // 
            // pbtSalir
            // 
            this.pbtSalir.Image = global::Form_Usuario_Contrasenia.Properties.Resources.next;
            this.pbtSalir.Location = new System.Drawing.Point(17, 294);
            this.pbtSalir.Name = "pbtSalir";
            this.pbtSalir.Size = new System.Drawing.Size(100, 97);
            this.pbtSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtSalir.TabIndex = 3;
            this.pbtSalir.TabStop = false;
            this.pbtSalir.Click += new System.EventHandler(this.pbtSalir_Click);
            // 
            // pbtGuardar
            // 
            this.pbtGuardar.Image = global::Form_Usuario_Contrasenia.Properties.Resources.save1;
            this.pbtGuardar.Location = new System.Drawing.Point(17, 157);
            this.pbtGuardar.Name = "pbtGuardar";
            this.pbtGuardar.Size = new System.Drawing.Size(100, 106);
            this.pbtGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtGuardar.TabIndex = 2;
            this.pbtGuardar.TabStop = false;
            this.pbtGuardar.Click += new System.EventHandler(this.pbtGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(470, 42);
            this.label5.TabIndex = 22;
            this.label5.Text = "REGISTRO DE GESTION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 228);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.dtp2);
            this.panel2.Controls.Add(this.dtp1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbxModalid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txAño);
            this.panel2.Controls.Add(this.txNum);
            this.panel2.Location = new System.Drawing.Point(8, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 201);
            this.panel2.TabIndex = 31;
            // 
            // dtp2
            // 
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(242, 150);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(174, 20);
            this.dtp2.TabIndex = 18;
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(242, 118);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(174, 20);
            this.dtp1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(84, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "MODALIDAD";
            // 
            // cbxModalid
            // 
            this.cbxModalid.FormattingEnabled = true;
            this.cbxModalid.Items.AddRange(new object[] {
            "semestral",
            "anual"});
            this.cbxModalid.Location = new System.Drawing.Point(242, 25);
            this.cbxModalid.Name = "cbxModalid";
            this.cbxModalid.Size = new System.Drawing.Size(174, 21);
            this.cbxModalid.TabIndex = 13;
            this.cbxModalid.SelectionChangeCommitted += new System.EventHandler(this.cbxModalid_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "FECHA FIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUMERO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "AÑO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "FECHA INICIO";
            // 
            // txAño
            // 
            this.txAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAño.Location = new System.Drawing.Point(242, 84);
            this.txAño.Multiline = true;
            this.txAño.Name = "txAño";
            this.txAño.Size = new System.Drawing.Size(95, 22);
            this.txAño.TabIndex = 10;
            this.txAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBxNCarreraRC_KeyPress);
            // 
            // txNum
            // 
            this.txNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNum.Location = new System.Drawing.Point(242, 54);
            this.txNum.Multiline = true;
            this.txNum.Name = "txNum";
            this.txNum.Size = new System.Drawing.Size(73, 22);
            this.txNum.TabIndex = 8;
            this.txNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBxIdCarreraRC_KeyPress);
            // 
            // Registro_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(698, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Registro_Gestion";
            this.Text = "Registro_Gestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_Gestion_FormClosed);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtGuardar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbtSalir;
        private System.Windows.Forms.PictureBox pbtGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxModalid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txAño;
        private System.Windows.Forms.TextBox txNum;
    }
}