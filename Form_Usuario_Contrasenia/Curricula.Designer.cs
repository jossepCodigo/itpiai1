namespace Form_Usuario_Contrasenia
{
    partial class Curricula
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
            this.label7 = new System.Windows.Forms.Label();
            this.pBxSalirK = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstMat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSelc = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBxSalirK)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(457, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "SALIR";
            // 
            // pBxSalirK
            // 
            this.pBxSalirK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxSalirK.Image = global::Form_Usuario_Contrasenia.Properties.Resources.next;
            this.pBxSalirK.Location = new System.Drawing.Point(428, 44);
            this.pBxSalirK.MaximumSize = new System.Drawing.Size(100, 106);
            this.pBxSalirK.MinimumSize = new System.Drawing.Size(100, 106);
            this.pBxSalirK.Name = "pBxSalirK";
            this.pBxSalirK.Size = new System.Drawing.Size(100, 106);
            this.pBxSalirK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxSalirK.TabIndex = 3;
            this.pBxSalirK.TabStop = false;
            this.pBxSalirK.Click += new System.EventHandler(this.pBxSalirK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "MALLA CURRICULAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "SELECCIONAR CARRERA";
            // 
            // lstMat
            // 
            this.lstMat.FormattingEnabled = true;
            this.lstMat.Location = new System.Drawing.Point(22, 192);
            this.lstMat.Name = "lstMat";
            this.lstMat.Size = new System.Drawing.Size(181, 264);
            this.lstMat.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "MATERIAS";
            // 
            // lstSelc
            // 
            this.lstSelc.FormattingEnabled = true;
            this.lstSelc.Location = new System.Drawing.Point(352, 192);
            this.lstSelc.Name = "lstSelc";
            this.lstSelc.Size = new System.Drawing.Size(156, 264);
            this.lstSelc.TabIndex = 18;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(232, 270);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(69, 37);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "=>";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(433, 163);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 21;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "nivel";
            // 
            // Curricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(540, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.pBxSalirK);
            this.Controls.Add(this.lstSelc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Name = "Curricula";
            this.Text = "Curricula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Curricula_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pBxSalirK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pBxSalirK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSelc;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label label2;
    }
}