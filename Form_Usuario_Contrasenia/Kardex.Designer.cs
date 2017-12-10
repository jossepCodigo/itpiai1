namespace Form_Usuario_Contrasenia
{
    partial class Kardex
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
            this.label7 = new System.Windows.Forms.Label();
            this.pBxGuardarK = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pBxSalirK = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBxSTBachiK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBxNTBachiK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxGuardarK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxSalirK)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pBxGuardarK);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pBxSalirK);
            this.panel4.Location = new System.Drawing.Point(598, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 439);
            this.panel4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "SALIR";
            // 
            // pBxGuardarK
            // 
            this.pBxGuardarK.Image = global::Form_Usuario_Contrasenia.Properties.Resources.save1;
            this.pBxGuardarK.Location = new System.Drawing.Point(18, 29);
            this.pBxGuardarK.Name = "pBxGuardarK";
            this.pBxGuardarK.Size = new System.Drawing.Size(100, 106);
            this.pBxGuardarK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBxGuardarK.TabIndex = 2;
            this.pBxGuardarK.TabStop = false;
            this.pBxGuardarK.Click += new System.EventHandler(this.pBxGuardarK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "GUARDAR";
            // 
            // pBxSalirK
            // 
            this.pBxSalirK.Image = global::Form_Usuario_Contrasenia.Properties.Resources.next;
            this.pBxSalirK.Location = new System.Drawing.Point(18, 172);
            this.pBxSalirK.Name = "pBxSalirK";
            this.pBxSalirK.Size = new System.Drawing.Size(100, 97);
            this.pBxSalirK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBxSalirK.TabIndex = 3;
            this.pBxSalirK.TabStop = false;
            this.pBxSalirK.Click += new System.EventHandler(this.pBxSalirK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(228, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "KARDEX";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 257);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbCarrera);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tBxSTBachiK);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tBxNTBachiK);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(14, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 198);
            this.panel2.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(242, 17);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(198, 21);
            this.cbCarrera.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CARRERA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "SERIE TBACHILLER:";
            // 
            // tBxSTBachiK
            // 
            this.tBxSTBachiK.Location = new System.Drawing.Point(242, 77);
            this.tBxSTBachiK.Multiline = true;
            this.tBxSTBachiK.Name = "tBxSTBachiK";
            this.tBxSTBachiK.Size = new System.Drawing.Size(294, 24);
            this.tBxSTBachiK.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "NUMERO TBACHILLER:";
            // 
            // tBxNTBachiK
            // 
            this.tBxNTBachiK.Location = new System.Drawing.Point(242, 107);
            this.tBxNTBachiK.Multiline = true;
            this.tBxNTBachiK.Name = "tBxNTBachiK";
            this.tBxNTBachiK.Size = new System.Drawing.Size(294, 24);
            this.tBxNTBachiK.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "EMISION TBACHILLER:";
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(725, 340);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Kardex";
            this.Text = "Kardex";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxGuardarK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxSalirK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pBxSalirK;
        private System.Windows.Forms.PictureBox pBxGuardarK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBxNTBachiK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBxSTBachiK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}