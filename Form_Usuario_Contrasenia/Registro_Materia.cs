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
    public partial class Registro_Materia : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private MateriaCC matObt;

        public Registro_Materia(UsuarioController us, Formulario_Administrador pad)
        {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.matObt = new MateriaCC();
        }

        private void limpiarAtr()
        {
            this.matObt = new MateriaCC();
        }

        private void pBxSalirRM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txCarHorM_KeyPress(object sender, KeyPressEventArgs e)
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
            limpiarAtr();
            MateriaCC buscado = new MateriaCC();
            if (!TxSigMat.Text.Equals(""))
            {
                buscado.obtenerPorSigla(TxSigMat.Text);
            }else if (!txNomM.Text.Equals("")){
                buscado.obtenerPorNomb(txNomM.Text);
            }else{
                limpiarAtr();
                return;
            }
            limpiarCampos();
            this.matObt = buscado;
            cargarMateria();
        }
        private void cargarMateria()
        {
            if (this.matObt.Id == -1)
            {
                limpiarAtr();
                limpiarCampos();
                return;
            }
            this.TxSigMat.Text = this.matObt.Sigla.ToString();
            this.txNomM.Text = this.matObt.Nombre;
            this.txCarHorM.Text = this.matObt.Carga_h.ToString();
        }

        private void limpiarCampos(){
            this.TxSigMat.Text = "";
            this.txNomM.Text = "";
            this.txCarHorM.Text = "";
        }

        private void pBxGuardarRM_Click(object sender, EventArgs e)
        {
            if (this.matObt.Id == -1)
            {
                if (MessageBox.Show("Desea Registrar la nueva materia " + txNomM.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MateriaCC matInsc = new MateriaCC();
                    matInsc.Sigla = this.TxSigMat.Text;
                    matInsc.Nombre = txNomM.Text;
                    matInsc.Carga_h = int.Parse(txCarHorM.Text);
                    matInsc.insertar();
                    this.matObt = matInsc;
                    limpiarCampos();
                    cargarMateria();
                }
            }
            else
            {
                if (MessageBox.Show("Desea Modificar La materia " + txNomM.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.matObt.Sigla = this.TxSigMat.Text;
                    this.matObt.Nombre = this.txNomM.Text;
                    this.matObt.Carga_h = int.Parse(this.txCarHorM.Text);
                    this.matObt.update();
                    limpiarCampos();
                    cargarMateria();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            limpiarCampos();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Materia_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            matObt.Activo = false;
            matObt.update();
            limpiarAtr();
            limpiarCampos();
        }

        private void Registro_Materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }
    }
}