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
    public partial class Registro_Administrador : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private AdminstradorCC adminObt;
        private List<TelefonoCC> telefonosAgregar;

        public Registro_Administrador(UsuarioController us, Formulario_Administrador pad)
        {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.adminObt = new AdminstradorCC();
            this.telefonosAgregar = new List<TelefonoCC>();
        }

        private void pBxSalirRA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBxGuardarRA_Click(object sender, EventArgs e)
        {
            if (this.adminObt.Id == -1)
            {
                if (MessageBox.Show("Desea Registrar al Nuevo Administrador " + this.txNombre.Text +
                    " " + this.txApp.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UsuarioController usIns = new UsuarioController();
                    usIns.setUserName(txUser.Text);
                    usIns.setPasswords(txPass.Text);
                    usIns.setTipoUser("administrador");
                    usIns.insertar();
                    PersonaCC perIns = new PersonaCC();
                    perIns.User = usIns;
                    perIns.Ci = int.Parse(txCi.Text);
                    perIns.Nombre = txNombre.Text;
                    perIns.Apellido_p = txApp.Text;
                    perIns.Apellido_m = txApm.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    perIns.Sexo = ss;
                    perIns.Domicilio = txDir.Text;
                    perIns.Correo = txCorr.Text;
                    perIns.Nacionalidad = txNacion.Text;
                    perIns.Nacimiento = dTP1.Value;
                    perIns.insertar();
                    AdminstradorCC adminIns = new AdminstradorCC();
                    adminIns.IdPersona = perIns;
                    adminIns.Cargo = txCargo.Text;
                    adminIns.Imagen = "";
                    adminIns.insertar();
                    this.adminObt = adminIns;
                    guardarTelefonos();
                }
            }else{
                if (MessageBox.Show("Desea Modificar Datos del Administrador"+this.txNombre.Text +
                    " " + this.txApp.Text + "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.adminObt.IdPersona.User.setUserName(txUser.Text);
                    this.adminObt.IdPersona.User.setPasswords(txPass.Text);
                    this.adminObt.IdPersona.User.update();
                    this.adminObt.IdPersona.Ci = int.Parse(txCi.Text);
                    this.adminObt.IdPersona.Nombre = txNombre.Text;
                    this.adminObt.IdPersona.Apellido_p = txApp.Text;
                    this.adminObt.IdPersona.Apellido_m = txApm.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    this.adminObt.IdPersona.Sexo = ss;
                    this.adminObt.IdPersona.Domicilio = txDir.Text;
                    this.adminObt.IdPersona.Correo = txCorr.Text;
                    this.adminObt.IdPersona.Nacionalidad = txNacion.Text;
                    this.adminObt.IdPersona.Nacimiento = dTP1.Value;
                    this.adminObt.IdPersona.update();
                    this.adminObt.Cargo = txCargo.Text;
                    this.adminObt.Imagen = "";
                    this.adminObt.update();
                }
            }
        }
        private void guardarTelefonos()
        {
            for (int i = 0; i < this.telefonosAgregar.Count; i++)
            {
                telefonosAgregar.ElementAt(i).IdPersona = adminObt.IdPersona;
                telefonosAgregar.ElementAt(i).insertar();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            limpiarCampos();
        }
        private void limpiarAtr()
        {
            this.adminObt = new AdminstradorCC();
            this.telefonosAgregar = new List<TelefonoCC>();
        }

        private void limpiarCampos()
        {
            this.txCi.Text = "";
            this.txUser.Text = "";
            this.txPass.Text = "";
            this.txNombre.Text = "";
            this.txApp.Text = "";
            this.txApm.Text = "";
            this.radioB1.Checked = false; this.radioB2.Checked = false;
            this.txDir.Text = "";
            this.txNacion.Text = "";
            this.txCorr.Text = "";
            this.dTP1 = new DateTimePicker();
            this.txCargo.Text = "";
        }

        private void pBxCancelarRA_Click(object sender, EventArgs e)
        {
            if (this.adminObt.Id != -1){
                this.adminObt.IdPersona.User.setActivo(false);
                this.adminObt.IdPersona.User.update();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.adminObt.Id != -1){
                this.adminObt.IdPersona.User.desbloquear();
            }
        }

        private void pBxKardexRA_Click(object sender, EventArgs e)
        {
            Telefono fono = new Telefono(this.telefonosAgregar, this.adminObt.IdPersona);
            fono.Show();
        }

        private void tbBuscar_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            AdminstradorCC buscado = new AdminstradorCC();
            buscado.obtenerPorCi(int.Parse(this.txCi.Text));
            this.adminObt = buscado;
            cargarAdmin();
        }
        private void cargarAdmin()
        {
            if (this.adminObt.Id == -1)return;
            this.txCi.Text = this.adminObt.IdPersona.Ci.ToString();
            this.txUser.Text = this.adminObt.IdPersona.User.getUserName();
            this.txPass.Text = this.adminObt.IdPersona.User.getPasswords();
            this.txNombre.Text = this.adminObt.IdPersona.Nombre;
            this.txApp.Text = this.adminObt.IdPersona.Apellido_p;
            this.txApm.Text = this.adminObt.IdPersona.Apellido_m;
            if (this.adminObt.IdPersona.Sexo == 1){
                this.radioB1.Checked = true; this.radioB2.Checked = false;
            }else{
                this.radioB2.Checked = true; this.radioB1.Checked = false;
            }
            this.txDir.Text = this.adminObt.IdPersona.Domicilio;
            this.txCorr.Text = this.adminObt.IdPersona.Correo;
            this.txNacion.Text = this.adminObt.IdPersona.Nacionalidad;
            this.dTP1.Value = this.adminObt.IdPersona.Nacimiento;
            this.txCargo.Text = this.adminObt.Cargo;
        }

        private void Registro_Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }

        private void txCi_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}