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
    public partial class Registro_Aula : Form
    {
        private UsuarioController user;
        private Form padre;
        private AulaCC aulaObt;

        public Registro_Aula(UsuarioController us, Form pad)
        {
            this.padre = pad;
            this.user = us;
            InitializeComponent();
            this.aulaObt = new AulaCC();
        }

        private void pBxSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBxGuardar_Click(object sender, EventArgs e){
            if (this.aulaObt.Id == -1){
                if (MessageBox.Show("Desea Registrar la nueva aula " + txNombAula.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    AulaCC aulIns = new AulaCC();
                    aulIns.Nombre = this.txNombAula.Text;
                    aulIns.Capacidad = int.Parse(txCapAula.Text);
                    aulIns.Piso = int.Parse(txPiso.Text);
                    aulIns.insertar();
                    this.aulaObt = aulIns;
                    limpiarCampos();
                    cargarAula();
                }
            }else{
                if (MessageBox.Show("Desea Modificar La Aula " + txNombAula.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    aulaObt.Capacidad = int.Parse(txCapAula.Text);
                    aulaObt.Piso = int.Parse(txPiso.Text);
                    this.aulaObt.update();
                    limpiarCampos();
                    cargarAula();
                }
            }
        }

        private void limpiarCampos() {
            this.txNombAula.Text = "";
            this.txCapAula.Text = "";
            this.txPiso.Text = "";
        }

        private void cargarAula() {
            txNombAula.Text = this.aulaObt.Nombre;
            txCapAula.Text = this.aulaObt.Capacidad.ToString();
            txPiso.Text = this.aulaObt.Piso.ToString();
        }

        private void Registro_Aula_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }

        private void txCapAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.aulaObt = new AulaCC();
            AulaCC buscado = new AulaCC();
            if (!txNombAula.Text.Equals("")){
                buscado.obtener(txNombAula.Text);
                if (buscado.Id == -1) {
                    limpiarCampos();
                    return;
                }
            }else{
                return;
            }
            limpiarCampos();
            this.aulaObt=buscado;
            cargarAula();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.aulaObt = new AulaCC();
            limpiarCampos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            aulaObt.Activo = false;
            aulaObt.update();
            limpiarCampos();
            this.aulaObt = new AulaCC();
        }
    }
}
