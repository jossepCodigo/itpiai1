using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Usuario_Contrasenia
{
    public partial class Formulario_Docente : Form
    {
        public Formulario_Docente()
        {
            InitializeComponent();
        }

        private void pBxSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Formulario_Docente_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
