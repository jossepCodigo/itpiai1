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
    public partial class Formulario_Administrador : Form
    {
        Usuario_Contrasenia padre;
        private UsuarioController user;

        public Formulario_Administrador(Usuario_Contrasenia pad,UsuarioController us)
        {
            this.padre = pad;
            this.user = us;
            InitializeComponent();
        }

        private void pBxInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion i = new Inscripcion();
            i.Show();
        }

        private void pBxCPestudiante_Click(object sender, EventArgs e)
        {
        }

        private void pBxCPdocente_Click(object sender, EventArgs e)
        {
        }

        private void pBxCUsecretaria_Click(object sender, EventArgs e)
        {
        }

        private void pBxCUadministrador_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Carrera rc = new Registro_Carrera(this.user, this);
            rc.Show();
        }

        private void pBxRSecretariaFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Secretaria rs = new Registro_Secretaria(this.user, this);
            rs.Show();
        }

        private void pBxRAdministradorFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Administrador ra = new Registro_Administrador(this.user, this);
            ra.Show();
        }

        private void pBxRMateriaFA_Click(object sender, EventArgs e)
        {
            Registro_Materia rm = new Registro_Materia(this.user, this);
            rm.Show();
        }

        private void pBxRAulaFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Aula ral = new Registro_Aula(this.user,this);
            ral.Show();
        }

        private void pBxRHorariosFA_Click(object sender, EventArgs e)
        {
            Registro_Horario rh = new Registro_Horario();
            rh.Show();
        }

        private void pBxSalirFA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pBxREstudianteFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Estudiante re = new Registro_Estudiante(this.user, this);
            re.Show();
        }

        private void pBxRDocente1FA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Docente rd = new Registro_Docente(this.user, this);
            rd.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formulario_Administrador_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void Formulario_Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Formulario_Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Close();
        }

        private void pbGest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Gestion rg = new Registro_Gestion(this.user, this);
            rg.Show();
        }

        private void pBxBoletinFA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Curricula cr = new Curricula(this.user, this);
            cr.Show();
        }

        private void pbxPlanificacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanificacionCurso cpl = new PlanificacionCurso(this.user, this);
            cpl.Show();
        }
    }
}