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
    public partial class Registro_Gestion : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private GestionCC gestionObt;

        public Registro_Gestion(UsuarioController us, Formulario_Administrador pad)
        {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.gestionObt = new GestionCC();
        }

        private void tBxIdCarreraRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }

        private void tBxNCarreraRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
        private void limpiarAtr()
        {
            this.gestionObt = new GestionCC();
        }
        private void cbxModalid_SelectionChangeCommitted(object sender, EventArgs e){
            string modalidad = cbxModalid.SelectedItem.ToString();
            if (!GestionCC.existeActivo(modalidad)) {
                limpiarAtr();
                limpiarCampos();
                cbxModalid.SelectedIndex = 0;
                if (modalidad.Equals("anual")) cbxModalid.SelectedIndex = 1;
                return;
            }
            GestionCC buscado = new GestionCC();
            buscado.obtenerActivo(cbxModalid.SelectedItem.ToString());
            limpiarAtr();
            limpiarCampos();
            this.gestionObt = buscado;
            cargarGestion();
            
        }
        private void limpiarCampos(){
            this.cbxModalid.Text = "";
            this.txNum.Text = "";
            this.txAño.Text = "";
            this.dtp1.ResetText();
            this.dtp2.ResetText();
            this.cbxModalid.SelectedIndex = -1;
        }
        private void cargarGestion(){
            if (this.gestionObt.Id == -1){
                limpiarAtr();
                limpiarCampos();
                return;
            }
            if (gestionObt.Modalidad.Equals("semestral")){
                cbxModalid.SelectedIndex = 0;
            }else{
                cbxModalid.SelectedIndex = 1;
            }
            this.txNum.Text = this.gestionObt.Numero.ToString();
            this.txAño.Text = this.gestionObt.Año.ToString();
            this.dtp1.Value = this.gestionObt.FechaIni;
            this.dtp2.Value = this.gestionObt.FechaFin;
        }

        private void Registro_Gestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }

        private void pbtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbtGuardar_Click(object sender, EventArgs e)
        {
            if (this.gestionObt.Id == -1)
            {
                if (MessageBox.Show("Desea Registrar la nueva Gestion"+txNum.Text+" del año "+txAño.Text+"?","?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes){

                    GestionCC gestIns = new GestionCC();
                    GestionCC gverif = new GestionCC();
                    gestIns.Modalidad = this.cbxModalid.SelectedItem.ToString();
                    gestIns.Numero = int.Parse(txNum.Text);
                    gestIns.Año = int.Parse(txAño.Text);
                    gestIns.FechaIni = dtp1.Value;
                    gestIns.FechaFin = dtp2.Value;
                    gverif.obtener(int.Parse(txNum.Text), int.Parse(txAño.Text), this.cbxModalid.SelectedItem.ToString());
                    if (gverif.Id != -1)
                    {
                        MessageBox.Show("esa gestion ya existe");
                        return;
                    }
                    gestIns.insertar();
                    this.gestionObt = gestIns;
                    limpiarCampos();
                    cargarGestion();
                }
            }else{
                if (MessageBox.Show("Desea Modificar las fechas de la gestion "+ txNum.Text + " del año " + 
                    txAño.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.gestionObt.FechaIni = dtp1.Value;
                    this.gestionObt.FechaFin = dtp2.Value;
                    this.gestionObt.update();
                    limpiarCampos();
                    cargarGestion();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.gestionObt.Activo = false;
            this.gestionObt.update();
            limpiarCampos();
            limpiarAtr();
        }
    }
}