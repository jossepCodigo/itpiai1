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
    public partial class Formulario_Secretaria : Form
    {
        Usuario_Contrasenia padre;
        private UsuarioController user;

        public Formulario_Secretaria(Usuario_Contrasenia pad, UsuarioController us)
        {
            this.padre = pad;
            this.user = us;
            InitializeComponent();
        }

        private void pBxREstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Estudiante re = new Registro_Estudiante(this.user, this);
            re.Show();
        }

        private void pBxRDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Docente rd = new Registro_Docente(this.user, this);
            rd.Show();
        }

        private void pBxInscripcion_Click(object sender, EventArgs e)
        {
        }

        private void pBxREstFS_Click(object sender, EventArgs e)
        {
        }

        private void pBxRDocenFS_Click(object sender, EventArgs e)
        {
        }

        private void pBxSalirFS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBxCodITPIAIFS_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formulario_Secretaria_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void pBxCancelarFS_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_Secretaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Close();
        }
    }
}
