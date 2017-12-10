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
    public partial class Registro_Estudiante : Form
    {
        private UsuarioController user;
        private Form padre;
        private EstudianteCC estObt;
        private List<TelefonoCC> telefonosAgregar;
        private KardexCC kar;

        public Registro_Estudiante(UsuarioController us, Form pad)
        {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.estObt = new EstudianteCC();
            this.telefonosAgregar = new List<TelefonoCC>();
            this.kar = new KardexCC();
        }

        private void pBxGuardarRE_Click(object sender, EventArgs e)
        {
            if (this.estObt.CodItp == -1)
            {
                if (MessageBox.Show("Desea Registrar al Nuevo Estudiante " + this.tBxNom.Text + " " + this.tBxApp.Text + "?", "No?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UsuarioController usIns = new UsuarioController();
                    usIns.setUserName(tBxUs.Text);
                    usIns.setPasswords(tBxPass.Text);
                    usIns.setTipoUser("estudiante");
                    usIns.insertar();
                    PersonaCC perIns = new PersonaCC();
                    perIns.User = usIns;
                    perIns.Ci = int.Parse(tBxNumCarnRE.Text);
                    perIns.Nombre = tBxNom.Text;
                    perIns.Apellido_p = tBxApp.Text;
                    perIns.Apellido_m = tBxApm.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    perIns.Sexo = ss;
                    perIns.Domicilio = tBxDir.Text;
                    perIns.Correo = tBxCorr.Text;
                    perIns.Nacionalidad = tBxNacion.Text;
                    perIns.Nacimiento = dTNac.Value;
                    perIns.insertar();
                    EstudianteCC estIns = new EstudianteCC();
                    estIns.CodItp = generar();
                    estIns.IdPersona = perIns;
                    estIns.AñoIng = int.Parse(tbxAnoI.Text);
                    estIns.Imagen = "";
                    estIns.insertar();
                    this.estObt = estIns;
                    guardarTelefonos();
                    kar.EstObt = estObt;
                    kar.insertar();
                }
            }else{
                if (MessageBox.Show("Desea Modificar Datos del Docente "+this.tBxNom.Text+" "+this.tBxApp.Text+ "?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.estObt.IdPersona.User.setUserName(tBxUs.Text);
                    this.estObt.IdPersona.User.setPasswords(tBxPass.Text);
                    this.estObt.IdPersona.User.update();
                    this.estObt.IdPersona.Ci = int.Parse(tBxNumCarnRE.Text);
                    this.estObt.IdPersona.Nombre = tBxNom.Text;
                    this.estObt.IdPersona.Apellido_p = tBxApp.Text;
                    this.estObt.IdPersona.Apellido_m = tBxApm.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    this.estObt.IdPersona.Sexo = ss;
                    this.estObt.IdPersona.Domicilio = tBxDir.Text;
                    this.estObt.IdPersona.Correo = tBxCorr.Text;
                    this.estObt.IdPersona.Nacionalidad = tBxNacion.Text;
                    this.estObt.IdPersona.Nacimiento = dTNac.Value;
                    this.estObt.IdPersona.update();
                    this.estObt.CodItp = int.Parse(tBxCodITPIAIRE.Text);
                    this.estObt.AñoIng = int.Parse(tbxAnoI.Text);
                    this.estObt.Imagen = "";
                    this.estObt.update();
                }
            }
        }

        private void guardarTelefonos()
        {
            for (int i = 0; i < this.telefonosAgregar.Count; i++){
                telefonosAgregar.ElementAt(i).IdPersona = estObt.IdPersona;
                telefonosAgregar.ElementAt(i).insertar();
            }
        }
        private int generar() {
            return 11211;
        }

        private void pBxKardex_Click(object sender, EventArgs e)
        {

        }

        private void pBxSalirRE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            EstudianteCC buscado = new EstudianteCC();
            if (!this.tBxCodITPIAIRE.Text.Equals(""))
            {
                buscado.obtenerPorCod(int.Parse(this.tBxCodITPIAIRE.Text));
            }else if(!this.tBxNumCarnRE.Text.Equals("")){
                buscado.obtenerPorCi(int.Parse(this.tBxNumCarnRE.Text));
            }
            this.estObt = buscado;
            if (estObt.CodItp != -1){
                kar.obtenerPorCodItpi(this.estObt.CodItp);
            }
            cargarEst();
        }

        private void cargarEst()
        {
            if (this.estObt.CodItp == -1){
                return;
            }
            this.tBxCodITPIAIRE.Text = this.estObt.CodItp.ToString();
            this.tBxNumCarnRE.Text = this.estObt.IdPersona.Ci.ToString();
            this.tBxUs.Text = this.estObt.IdPersona.User.getUserName();
            this.tBxPass.Text = this.estObt.IdPersona.User.getPasswords();
            this.tBxNom.Text = this.estObt.IdPersona.Nombre;
            this.tBxApp.Text = this.estObt.IdPersona.Apellido_p;
            this.tBxApm.Text = this.estObt.IdPersona.Apellido_m;
            if (this.estObt.IdPersona.Sexo == 1){
                this.radioB1.Checked = true; this.radioB2.Checked = false;
            }else{
                this.radioB2.Checked = true; this.radioB1.Checked = false;
            }
            this.tBxDir.Text = this.estObt.IdPersona.Domicilio;
            this.tBxCorr.Text = this.estObt.IdPersona.Correo;
            this.tBxNacion.Text = this.estObt.IdPersona.Nacionalidad;
            this.dTNac.Value = this.estObt.IdPersona.Nacimiento;
            this.tbxAnoI.Text = this.estObt.AñoIng.ToString();
        }
        private void limpiarAtr()
        {
            this.estObt = new EstudianteCC();
            this.telefonosAgregar = new List<TelefonoCC>();
            this.kar = new KardexCC();
        }
        private void tBxNumCarnRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }

        private void Registro_Estudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Telefono fono = new Telefono(this.telefonosAgregar, this.estObt.IdPersona);
            fono.Show();
        }

        private void pBxCancelarRE_Click(object sender, EventArgs e)
        {
            if (this.estObt.CodItp != -1)
            {
                this.estObt.IdPersona.User.setActivo(false);
                this.estObt.IdPersona.User.update();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.estObt.CodItp != -1){
                this.estObt.IdPersona.User.desbloquear();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Kardex k = new Kardex(this.kar, this.estObt);
            k.Show();
        }
    }
}