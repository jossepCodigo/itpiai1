using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPANEGOCIO;

namespace Form_Usuario_Contrasenia
{
    public partial class Registro_Carrera : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private CarreraCC carrObt;

        public Registro_Carrera(UsuarioController us, Formulario_Administrador pad)
        {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.carrObt = new CarreraCC();
            //this.padre.FormBorderStyle= FormBorderStyle.None;
            //this.padre.WindowState = FormWindowState.Maximized;
            //this.padre.BackColor = Color.Gray;
            //this.Opacity = 0.9;
        }
        private void limpiarAtr()
        {
            this.carrObt = new CarreraCC();
        }
        private void pBxSalirRC_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            CarreraCC buscado = new CarreraCC();
            if (!tBxIdCarreraRC.Text.Equals(""))
            {
                buscado.obtenerPorId(int.Parse(tBxIdCarreraRC.Text));
            }
            else if (!tBxNCarreraRC.Text.Equals(""))
            {
                buscado.obtenerPorNomb(tBxNCarreraRC.Text);
            }
            else
            {
                limpiarAtr();
                return;
            }
            limpiarCampos();
            this.carrObt = buscado;
            cargarCarrera();
        }
        private void cargarCarrera()
        {
            if (this.carrObt.Id == -1)
            {
                limpiarAtr();
                limpiarCampos();
                return;
            }
            this.tBxIdCarreraRC.Text = this.carrObt.Id.ToString();
            this.tBxNCarreraRC.Text = this.carrObt.Nombre;
            if (carrObt.Modalidad.Equals("semestral")){
                cBxTModalidadRC.SelectedIndex = 0;
            }else {
                cBxTModalidadRC.SelectedIndex = 1;
            }
            this.comboBox1.SelectedIndex = this.carrObt.Duracion - 1;
        }
        private void Registro_Carrera_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Opacity = 1;
            this.padre.Show();
        }

        private void tBxIdCarreraRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            limpiarCampos();
        }
        private void limpiarCampos() {
            this.tBxIdCarreraRC.Text = "";
            this.tBxNCarreraRC.Text = "";
            this.cBxTModalidadRC.SelectedIndex = -1;
            this.comboBox1.SelectedIndex = -1;
        }

        private void pBxGuardarRC_Click(object sender, EventArgs e)
        {
            if (this.carrObt.Id == -1){
                if (MessageBox.Show("Desea Registrar la nueva carrera de" + tBxNCarreraRC.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CarreraCC carrIns = new CarreraCC();
                    carrIns.Nombre = this.tBxNCarreraRC.Text;
                    carrIns.Modalidad = cBxTModalidadRC.SelectedText;
                    carrIns.Duracion = int.Parse(comboBox1.SelectedText);
                    carrIns.insertar();
                    this.carrObt = carrIns;
                    limpiarCampos();
                    cargarCarrera();
                }
            }else{
                if (MessageBox.Show("Desea Modificar La carrera " + tBxNCarreraRC.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.carrObt.Nombre = this.tBxNCarreraRC.Text;
                    if (cBxTModalidadRC.SelectedIndex == 0)
                    {
                        this.carrObt.Modalidad = "semestral";
                    }
                    else {
                        this.carrObt.Modalidad = "anual";
                    }
                    this.carrObt.Duracion = comboBox1.SelectedIndex+1;
                    this.carrObt.update();
                    limpiarCampos();
                    cargarCarrera();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.carrObt.Id != -1)
            {
                this.carrObt.Activo = false;
                this.carrObt.update();
            }
        }
    }
}