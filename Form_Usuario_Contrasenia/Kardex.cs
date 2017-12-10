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
    public partial class Kardex : Form
    {
        private KardexCC kar;
        private EstudianteCC est;

        public Kardex(KardexCC k,EstudianteCC es)
        {
            kar = k;
            est = es;
            InitializeComponent();
            cargarCarrera();
            if (this.est.CodItp != -1 && this.kar.IdKardex != -1){
                cargarKardex();
            }
        }

        private void cargarCarrera() {
            List<CarreraCC> listCarr = CarreraCC.all();
            for (int i = 0; i < listCarr.Count; i++)
            {
                cbCarrera.Items.Add(listCarr.ElementAt(i).Nombre);
            }
        }

        private void cargarKardex(){
            int indexC = -1;
            for (int i = 0; i < cbCarrera.Items.Count; i++)
            {
                if (cbCarrera.Items[i].Equals(kar.Carr.Nombre)){
                    indexC = i;
                }
            }
            cbCarrera.SelectedIndex = indexC;
            tBxSTBachiK.Text = kar.SerieTit;
            tBxNTBachiK.Text = kar.NumTit;
            dateTimePicker1.Value = kar.FechTit;
        }

        private void pBxSalirK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBxCITPIAIK_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pBxGuardarK_Click(object sender, EventArgs e)
        {
            string nomCarr = cbCarrera.SelectedItem.ToString();
            CarreraCC carrObt = new CarreraCC();
            carrObt.obtenerPorNomb(nomCarr);
            kar.Carr = carrObt;
            kar.SerieTit = tBxSTBachiK.Text;
            kar.NumTit = tBxNTBachiK.Text;
            kar.FechTit = dateTimePicker1.Value;
            kar.Estado = "creado";
            kar.Activo = true;
            if (this.est.CodItp != -1 && this.kar.IdKardex != -1){
                kar.update();
            }else {

            }
        }
    }
}