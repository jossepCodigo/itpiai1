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
    public partial class Registro_Docente : Form
    {
        private UsuarioController user;
        private List<EspecialidadCC> especialidadAgregar;
        private DocenteCC docenteObtenido;
        private List<TelefonoCC> telefonosAgregar;
        private Form padre;

        public Registro_Docente(UsuarioController us,Form pad)
        {
            this.padre = pad;
            InitializeComponent();
            this.especialidadAgregar = new List<EspecialidadCC>();
            this.user = us;
            this.docenteObtenido = new DocenteCC();
            this.telefonosAgregar = new List<TelefonoCC>();
        }

        private void pBxSalirRD_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBxKardexRD_Click(object sender, EventArgs e)
        {
            Especialidad k = new Especialidad(especialidadAgregar,this.docenteObtenido);
            k.Show();
        }

        private void Registro_Docente_Load(object sender, EventArgs e)
        {

        }

        private void pBxImagenRD_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telefono fono = new Telefono(this.telefonosAgregar, this.docenteObtenido.IdPersona);
            fono.Show();
        }

        private void pBxCancelarRD_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            limpiarCampos();
        }

        private void limpiarAtr() {
            this.docenteObtenido = new DocenteCC();
            this.especialidadAgregar = new List<EspecialidadCC>();
            this.telefonosAgregar = new List<TelefonoCC>();
        }

        private void limpiarCampos() {
            this.txCi.Text = "";
            this.textBox2.Text = "";
            this.txPass.Text = "";
            this.txNom.Text = "";
            this.txApP.Text = "";
            this.txApM.Text = "";
            this.radioB1.Checked = false; this.radioB2.Checked = false;
            this.txDir.Text = "";
            this.txNacion.Text = "";
            this.txCorreo.Text = "";
            this.dTNac = new DateTimePicker(); this.dTNac.Value = DateTime.Now;
            this.dTIng = new DateTimePicker(); this.dTIng.Value = DateTime.Now;
        }

        private void pBxGuardarRD_Click(object sender, EventArgs e)
        {
            if (this.docenteObtenido.Id == -1)
            {
                if (MessageBox.Show("Desea Registrar al Nuevo Docente " + this.txNom.Text + " " + this.txApP.Text + "?", "No?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UsuarioController usIns = new UsuarioController();
                    usIns.setUserName(textBox2.Text);
                    usIns.setPasswords(txPass.Text);
                    usIns.setTipoUser("docente");
                    usIns.insertar();
                    PersonaCC perIns = new PersonaCC();
                    perIns.User = usIns;
                    perIns.Ci = int.Parse(txCi.Text);
                    perIns.Nombre = txNom.Text;
                    perIns.Apellido_p = txApP.Text;
                    perIns.Apellido_m = txApM.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    perIns.Sexo = ss;
                    perIns.Domicilio = txDir.Text;
                    perIns.Correo = txCorreo.Text;
                    perIns.Nacionalidad = txNacion.Text;
                    perIns.Nacimiento = dTNac.Value;
                    perIns.insertar();
                    DocenteCC docIns = new DocenteCC();
                    docIns.IdPersona = perIns;
                    docIns.FechaIngreso = dTIng.Value;
                    docIns.Imagen = "";
                    docIns.insertar();
                    this.docenteObtenido = docIns;
                    guardarTelefonos();
                    guardarEspecialidades();
                }
            }
            else
            {
                if (MessageBox.Show("Desea Modificar Datos del Docente " + this.txNom.Text + " " + this.txApP.Text + "?", "No?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.docenteObtenido.IdPersona.User.setUserName(textBox2.Text);
                    this.docenteObtenido.IdPersona.User.setPasswords(txPass.Text);
                    this.docenteObtenido.IdPersona.User.update();
                    this.docenteObtenido.IdPersona.Ci=int.Parse(txCi.Text);
                    this.docenteObtenido.IdPersona.Nombre = txNom.Text;
                    this.docenteObtenido.IdPersona.Apellido_p = txApP.Text;
                    this.docenteObtenido.IdPersona.Apellido_m = txApM.Text;
                    byte ss = 0;
                    if (radioB1.Checked) { ss = 1; }
                    else if (radioB2.Checked) { ss = 0; }
                    this.docenteObtenido.IdPersona.Sexo = ss;
                    this.docenteObtenido.IdPersona.Domicilio = txDir.Text;
                    this.docenteObtenido.IdPersona.Correo = txCorreo.Text;
                    this.docenteObtenido.IdPersona.Nacionalidad = txNacion.Text;
                    this.docenteObtenido.IdPersona.Nacimiento = dTNac.Value;
                    this.docenteObtenido.IdPersona.update();
                    this.docenteObtenido.FechaIngreso = dTIng.Value;
                    this.docenteObtenido.Imagen = "";
                    this.docenteObtenido.update();
                }
            }
        }

        private void guardarEspecialidades() {
            for (int i = 0; i < this.especialidadAgregar.Count; i++){
                EspecialidadCC.insertarED(this.docenteObtenido.Id, 
                    this.especialidadAgregar.ElementAt(i).getNombre());
            }
        }

        private void guardarTelefonos() {
            for (int i = 0; i < this.telefonosAgregar.Count; i++)
            {
                telefonosAgregar.ElementAt(i).IdPersona=docenteObtenido.IdPersona;
                telefonosAgregar.ElementAt(i).insertar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarAtr();
            DocenteCC buscado = new DocenteCC();
            buscado.obtenerPorCi(int.Parse(this.txCi.Text));
            this.docenteObtenido = buscado;
            cargarDocente();
        }

        private void cargarDocente() {
            if (this.docenteObtenido.Id == -1)
            {
                return;
            }
            this.txCi.Text = this.docenteObtenido.IdPersona.Ci.ToString();
            this.textBox2.Text = this.docenteObtenido.IdPersona.User.getUserName();
            this.txPass.Text = this.docenteObtenido.IdPersona.User.getPasswords();
            this.txNom.Text = this.docenteObtenido.IdPersona.Nombre;
            this.txApP.Text = this.docenteObtenido.IdPersona.Apellido_p;
            this.txApM.Text = this.docenteObtenido.IdPersona.Apellido_m;
            if (this.docenteObtenido.IdPersona.Sexo == 1){
                this.radioB1.Checked = true;this.radioB2.Checked = false;
            }else {
                this.radioB2.Checked = true; this.radioB1.Checked = false;
            }
            this.txDir.Text = this.docenteObtenido.IdPersona.Domicilio;
            this.txCorreo.Text = this.docenteObtenido.IdPersona.Correo;
            this.txNacion.Text = this.docenteObtenido.IdPersona.Nacionalidad;
            this.dTNac.Value = this.docenteObtenido.IdPersona.Nacimiento;
            this.dTIng.Value = this.docenteObtenido.FechaIngreso;
        }

        private void Registro_Docente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Show();
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            if (this.docenteObtenido.Id != -1)
            {
                this.docenteObtenido.IdPersona.User.setActivo(false);
                this.docenteObtenido.IdPersona.User.update();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (this.docenteObtenido.Id != -1)
            {
                this.docenteObtenido.IdPersona.User.desbloquear();
            }
        }

        private void txCi_TextChanged(object sender, EventArgs e)
        {

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