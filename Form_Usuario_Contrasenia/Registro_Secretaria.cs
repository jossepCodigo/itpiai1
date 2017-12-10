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
    public partial class Registro_Secretaria : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private SecretariaCC secretariaObt;
        private List<TelefonoCC> telefonosAgregar;

        public Registro_Secretaria(UsuarioController us,Formulario_Administrador pad)
        {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.secretariaObt = new SecretariaCC();
            this.telefonosAgregar = new List<TelefonoCC>();
        }

        private void pBxSalirRS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBxKardexRS_Click(object sender, EventArgs e){
            if (this.secretariaObt.Id != -1){
                this.secretariaObt.IdPersona.User.desbloquear();
            }
        }

        private void Registro_Secretaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }

        private void pBxGuardarRS_Click(object sender, EventArgs e){
            if (this.secretariaObt.Id == -1){
                if (MessageBox.Show("Desea Registrar a la Nueva Secretaria " + this.tBxNombreRS.Text +
                    " " + this.tBxApePatRS.Text + "?", "No?", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    UsuarioController usIns = new UsuarioController();
                    usIns.setUserName(textBox1.Text);
                    usIns.setPasswords(textBox2.Text);
                    usIns.setTipoUser("secretaria");
                    usIns.insertar();
                    PersonaCC perIns = new PersonaCC();
                    perIns.User = usIns;
                    perIns.Ci = int.Parse(tBxNumCarnRS.Text);
                    perIns.Nombre = tBxNombreRS.Text;
                    perIns.Apellido_p = tBxApePatRS.Text;
                    perIns.Apellido_m = tBxApeMatRS.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    perIns.Sexo = ss;
                    perIns.Domicilio = tBxDirecRS.Text;
                    perIns.Correo = tBxCorrElecRS.Text;
                    perIns.Nacionalidad = tBxNacion.Text;
                    perIns.Nacimiento = dateTimePicker1.Value;
                    perIns.insertar();
                    SecretariaCC secIns = new SecretariaCC();
                    secIns.IdPersona = perIns;
                    secIns.FechaIngreso = dateTimePicker2.Value;
                    secIns.Imagen = "";
                    secIns.insertar();
                    this.secretariaObt = secIns;
                    guardarTelefonos();
                }
            }else{
                if (MessageBox.Show("Desea Modificar Datos de la Secretaria " + this.tBxNombreRS.Text +
                    " " + this.tBxApePatRS.Text + "?", "No?", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    this.secretariaObt.IdPersona.User.setUserName(textBox1.Text);
                    this.secretariaObt.IdPersona.User.setPasswords(textBox2.Text);
                    this.secretariaObt.IdPersona.User.update();
                    this.secretariaObt.IdPersona.Ci = int.Parse(tBxNumCarnRS.Text);
                    this.secretariaObt.IdPersona.Nombre = tBxNombreRS.Text;
                    this.secretariaObt.IdPersona.Apellido_p = tBxApePatRS.Text;
                    this.secretariaObt.IdPersona.Apellido_m = tBxApeMatRS.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    this.secretariaObt.IdPersona.Sexo = ss;
                    this.secretariaObt.IdPersona.Domicilio = tBxDirecRS.Text;
                    this.secretariaObt.IdPersona.Correo = tBxCorrElecRS.Text;
                    this.secretariaObt.IdPersona.Nacionalidad = tBxNacion.Text;
                    this.secretariaObt.IdPersona.Nacimiento = dateTimePicker1.Value;
                    this.secretariaObt.IdPersona.update();
                    this.secretariaObt.FechaIngreso = dateTimePicker2.Value;
                    this.secretariaObt.Imagen = "";
                    this.secretariaObt.update();
                }
            }
        }
        private void guardarTelefonos(){
            for (int i = 0; i < this.telefonosAgregar.Count; i++){
                telefonosAgregar.ElementAt(i).IdPersona = secretariaObt.IdPersona;
                telefonosAgregar.ElementAt(i).insertar();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e){
            limpiarAtr();
            limpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e){
            limpiarAtr();
            SecretariaCC buscado = new SecretariaCC();
            buscado.obtenerPorCi(int.Parse(this.tBxNumCarnRS.Text));
            this.secretariaObt = buscado;
            cargarSecre();
        }

        private void cargarSecre(){
            if (this.secretariaObt.Id == -1){
                return;
            }
            this.tBxNumCarnRS.Text = this.secretariaObt.IdPersona.Ci.ToString();
            this.textBox1.Text = this.secretariaObt.IdPersona.User.getUserName();
            this.textBox2.Text = this.secretariaObt.IdPersona.User.getPasswords();
            this.tBxNombreRS.Text = this.secretariaObt.IdPersona.Nombre;
            this.tBxApePatRS.Text = this.secretariaObt.IdPersona.Apellido_p;
            this.tBxApeMatRS.Text = this.secretariaObt.IdPersona.Apellido_m;
            if (this.secretariaObt.IdPersona.Sexo == 1){
                this.radioB1.Checked = true; this.radioB2.Checked = false;
            }else{
                this.radioB2.Checked = true; this.radioB1.Checked = false;
            }
            this.tBxDirecRS.Text = this.secretariaObt.IdPersona.Domicilio;
            this.tBxCorrElecRS.Text = this.secretariaObt.IdPersona.Correo;
            this.tBxNacion.Text = this.secretariaObt.IdPersona.Nacionalidad;
            this.dateTimePicker1 .Value = this.secretariaObt.IdPersona.Nacimiento;
            this.dateTimePicker2.Value = this.secretariaObt.FechaIngreso;
        }

        private void limpiarAtr(){
            this.secretariaObt = new SecretariaCC();
            this.telefonosAgregar = new List<TelefonoCC>();
        }

        private void limpiarCampos(){
            this.tBxNumCarnRS.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.tBxNombreRS.Text = "";
            this.tBxApePatRS.Text = "";
            this.tBxApeMatRS.Text = "";
            this.radioB1.Checked = false; this.radioB2.Checked = false;
            this.tBxDirecRS.Text = "";
            this.tBxNacion.Text = "";
            this.tBxCorrElecRS.Text = "";
            this.dateTimePicker1 = new DateTimePicker(); this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker2 = new DateTimePicker(); this.dateTimePicker2.Value = DateTime.Now;
        }

        private void pictureBox2_Click(object sender, EventArgs e){
            Telefono fono = new Telefono(this.telefonosAgregar, this.secretariaObt.IdPersona);
            fono.Show();
        }

        private void pBxCancelarRS_Click(object sender, EventArgs e){
            if (this.secretariaObt.Id != -1){
                this.secretariaObt.IdPersona.User.setActivo(false);
                this.secretariaObt.IdPersona.User.update();
            }
        }

        private void tBxNumCarnRS_KeyPress(object sender, KeyPressEventArgs e)
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