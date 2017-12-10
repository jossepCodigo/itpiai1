using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************//
using CAPANEGOCIO;
using System.Windows.Forms;
using System.Threading;

namespace Form_Usuario_Contrasenia
{
    
    public partial class Usuario_Contrasenia : Form
    {
        public Usuario_Contrasenia()
        {
            InitializeComponent();
        }
        
        private void pBxIngresar_Click(object sender, EventArgs e)
        {
            UsuarioController us = new UsuarioController();
            us.obtenerUsuario(tBxUsuarioUC.Text.ToString(), tBxContraseniaUC.Text.ToString());
            if (us.getID() != -1 && us.getActivo()==true && us.getIntentos()<4)
            {
                us.setIntentos(0);
                us.update();
                this.Hide();
                if (us.getTipoUser().Equals("administrador"))
                {
                    Formulario_Administrador fa = new Formulario_Administrador(this,us);
                    fa.Show();
                }
                else if (us.getTipoUser().Equals("estudiante"))
                {
                    Formulario_Estudiante fe = new Formulario_Estudiante();
                    fe.Show();
                }
                else if (us.getTipoUser().Equals("secretaria"))
                {
                    Formulario_Secretaria fs = new Formulario_Secretaria(this,us);
                    fs.Show();
                }
                else if (us.getTipoUser().Equals("docente"))
                {
                    Formulario_Docente fd = new Formulario_Docente();
                    fd.Show();
                }
            }
            else if (UsuarioController.existe(tBxUsuarioUC.Text.ToString()))
            {
                us.obtenerUsuario(tBxUsuarioUC.Text.ToString());
                us.aumentarInt();
                if (us.getActivo() == false)
                {
                    MessageBox.Show("Usuario Eliminado");
                }
                else if (us.getIntentos() > 3)
                {
                    MessageBox.Show("Usuario Bloqueado por Intentos fallidos");
                }
                else {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }else{
                MessageBox.Show("Usuario no Encontrado");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBxContraseniaUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Usuario_Contrasenia_Load(object sender, EventArgs e)
        {
            
        }
    }
}
