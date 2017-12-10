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
    public partial class Curricula : Form
    {
        private UsuarioController user;
        private Formulario_Administrador padre;
        private CurriculaCC CurrObt;

        public Curricula(UsuarioController us, Formulario_Administrador pad) {
            this.user = us;
            this.padre = pad;
            InitializeComponent();
            this.CurrObt = new CurriculaCC();
            cargarMat();
            cargarCarrera();
        }
        private void limpiarAtr() {
            this.CurrObt = new CurriculaCC();
        }
        private void limpiarCampos() {
            this.comboBox1.Text = "";
            this.comboBox1.SelectedIndex = -1;
            this.lstSelc = new ListBox();
        }
        private void cargarMat() {
            List<MateriaCC> mats = MateriaCC.all();
            for (int i = 0; i < mats.Count; i++) {
                lstMat.Items.Add(mats.ElementAt(i).Nombre);
            }
        }
        private void cargarCarrera() {
            List<CarreraCC> carrs = CarreraCC.all();
            for (int i = 0; i < carrs.Count; i++){
                comboBox1.Items.Add(carrs.ElementAt(i).Nombre);
            }
        }
        private void cargarMateriasCurr() {
            this.lstSelc.Items.Clear();
            if (CurrObt.Id == -1) return;
            List<string> mats = this.CurrObt.detalleMateria();
            for (int i = 0; i < mats.Count; i++){
                lstSelc.Items.Add(mats.ElementAt(i));
            }
        }
        private CurriculaCC obtenerCurricula() {
            string carrera = comboBox1.SelectedItem.ToString();
            CurriculaCC currOb = new CurriculaCC();
            currOb.obtenerPorNomCarr(carrera);
            return currOb;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){
            
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e){
            this.CurrObt = obtenerCurricula();
            cargarMateriasCurr();
        }

        private void Curricula_FormClosed(object sender, FormClosedEventArgs e){
            this.padre.Show();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("")){
                if (CurrObt.Id != -1) {
                    string selMat = obtenerMateria();
                    DetalleCurriculaCC nuevo = new DetalleCurriculaCC();
                    MateriaCC matt = new MateriaCC();
                    matt.obtenerPorNomb(selMat);
                    if (matt.Id!=-1){
                        nuevo.Id_curricula = CurrObt;
                        nuevo.Id_materia = matt;
                        nuevo.Nivel = int.Parse(textBox1.Text);
                        nuevo.insertar();
                        cargarMateriasCurr();
                    }
                }else {
                    MessageBox.Show("seleccione carrera");
                }
            }
            else {
                MessageBox.Show("ingrese nivel de la materia en la malla curricular");
            }
        }
        private string obtenerMateria() {
            return lstMat.SelectedItem.ToString();
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
        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (!lstSelc.SelectedItem.ToString().Equals("")){
                DetalleCurriculaCC borrar = new DetalleCurriculaCC();
                MateriaCC idMb = new MateriaCC();
                idMb.obtenerPorNomb(obtenerNomMat(lstSelc.SelectedItem.ToString()));
                borrar.obtenerPorCM(CurrObt.Id,idMb.Id, obtenerNivMat(lstSelc.SelectedItem.ToString()));
                borrar.Activo = false;
                borrar.update();
                cargarMateriasCurr();
            }
        }
        private string obtenerNomMat(string texto)
        {
            if (texto.Equals("")) return "";
            string resp = "";
            Char delimitador = ' ';
            String[] substrings = texto.Split(delimitador);
            resp = substrings[1];
            return resp;
        }
        private int obtenerNivMat(string texto)
        {
            if (texto.Equals("")) return -1;
            string resp = "";
            Char delimitador = ' ';
            String[] substrings = texto.Split(delimitador);
            resp = substrings[0];
            return int.Parse(resp);
        }
        private void pBxSalirK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}