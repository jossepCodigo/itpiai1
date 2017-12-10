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
    public partial class PlanificacionCurso : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private PlanificacionCC planObt;
        private List<PeriodoCC> listP;

        public PlanificacionCurso(UsuarioController us, Formulario_Administrador pad){
            this.padre = pad;
            this.user = us;
            InitializeComponent();
            this.planObt = new PlanificacionCC();
            this.listP = new List<PeriodoCC>();
            cargarGestiones();
        }
        private void cargarGestiones() {
            comboBox1.Items.Clear();
            List<GestionCC> gests = GestionCC.allActivo();
            for (int i = 0; i < gests.Count; i++){
                GestionCC act = gests.ElementAt(i);
                comboBox1.Items.Add(act.Modalidad+" "+act.Numero+" "+act.Año);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e){

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e){
        }

        private void PlanificacionCurso_FormClosed(object sender, FormClosedEventArgs e){
            this.padre.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e){
            label12.Text = "";
            
        }

            //label12.Text = "seleccionado : ";
            //for (int i = 0; i<checkedListBox1.CheckedIndices.Count; i++){
            //    int indexCheck = checkedListBox1.CheckedIndices[i];
            //    string diaa = "";
            //    switch (indexCheck){
            //        case 0: diaa = "lunes"; break;
            //        case 1: diaa = "martes"; break;
            //        case 2: diaa = "miercoles"; break;
            //        case 3: diaa = "jueves"; break;
            //        case 4: diaa = "viernes"; break;
            //        case 5: diaa = "sabado"; break;
            //        case 6: diaa = "domingo"; break;
            //        default:break;
            //    }
            //    label12.Text = label12.Text+diaa;
            //}
    }
}