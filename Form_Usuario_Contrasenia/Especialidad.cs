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
    public partial class Especialidad : Form
    {
        DocenteCC docente;
        List<EspecialidadCC> espAdd;
        List<EspecialidadCC> espTodos;
        List<EspecialidadCC> espSel;

        public Especialidad(List<EspecialidadCC> esp, DocenteCC doc){
            InitializeComponent();
            this.espAdd = esp;
            this.docente = doc;
            llenar();
        }

        private void Especialidad_Load(object sender, EventArgs e){
        }

        private void llenar(){
            llenarEspTodos();
            llenarEsp();
        }
        private void llenarEspTodos(){
            this.espTodos = EspecialidadCC.all(this.docente.Id);
            for (int i = 0; i < this.espTodos.Count; i++){
                listEsp.Items.Add(this.espTodos.ElementAt(i).getNombre());
            }
        }

        private void llenarEsp() {
            if (this.docente.Id != -1){
                this.espSel = EspecialidadCC.espDocente(this.docente.Id);
                for (int i = 0; i < this.espSel.Count; i++){
                    listAdd.Items.Add(this.espSel.ElementAt(i).getNombre());
                }
            }else{
                for (int i = 0; i < this.espAdd.Count; i++)
                {
                    listAdd.Items.Add(this.espAdd.ElementAt(i).getNombre());
                }
            }
        }

        public void limpiar(){
            limpiarEsp();
            limpiarSelec();
        }
        public void limpiarEsp(){
            this.listEsp.Items.Clear();
        }
        public void limpiarSelec(){
            this.listAdd.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e){
            string espSeleccionado = (listEsp.SelectedItem).ToString();
            if (docente.Id != -1){
                EspecialidadCC.insertarED(this.docente.Id, espSeleccionado);
                limpiar();
                llenar();
            }else {
                this.espAdd.Add(new EspecialidadCC(-1,espSeleccionado));
                limpiarSelec();
                llenarEsp();
            }
        }

        private void button2_Click(object sender, EventArgs e){
            EspecialidadCC nuevo = new EspecialidadCC();
            if (!textBox1.Text.Equals("")){
                nuevo.setNombre(textBox1.Text);
                nuevo.insertar();
            }
            limpiarEsp();
            llenarEspTodos();
            this.textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string espSeleccionado = (listEsp.SelectedItem).ToString();
            EspecialidadCC elim = new EspecialidadCC();
            elim.setNombre(espSeleccionado);
            elim.eliminar();
            limpiar();
            llenar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (docente.Id != -1)
            {
                string espSel = (listAdd.SelectedItem).ToString();
                EspecialidadCC.eliminarED(this.docente.Id, espSel);
                limpiar();
                llenar();
            }
            else {
                string espSel = (listAdd.SelectedItem).ToString();
                int elim = -1;
                for (int i = 0; i < this.espAdd.Count; i++){
                    if (this.espAdd.ElementAt(i).getNombre().Equals(espSel)) elim = i;
                }
                this.espAdd.RemoveAt(elim);
                limpiarSelec();
                llenarEsp();
            }
        }
    }
}