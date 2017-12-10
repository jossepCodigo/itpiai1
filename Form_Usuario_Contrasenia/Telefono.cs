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
    public partial class Telefono : Form
    {
        List<TelefonoCC> listTelefonoAdd;
        List<TelefonoCC> listaActual;
        PersonaCC persona = new PersonaCC();

        public Telefono(List<TelefonoCC> listaAgregar,PersonaCC per)
        {
            InitializeComponent();
            this.listTelefonoAdd = listaAgregar;
            this.persona = per;
        }

        private void Telefono_Load(object sender, EventArgs e)
        {
            cargarTelefonos();
            comboBox1.Items.Add("celular");
            comboBox1.Items.Add("casa");
            comboBox1.Items.Add("referencia");
            comboBox1.Items.Add("trabajo");
        }

        public void cargarTelefonos() {
            listaActual = TelefonoCC.telefonoPersona(persona.Id);
            for (int i = 0; i < listaActual.Count; i++)
            {
                lstFono.Items.Add(this.listaActual.ElementAt(i).Numero+"--->"+
                    this.listaActual.ElementAt(i).Tipo);
            }
            for (int i = 0; i < this.listTelefonoAdd.Count; i++)
            {
                lstFono.Items.Add(this.listTelefonoAdd.ElementAt(i).Numero+"--->"+
                    this.listTelefonoAdd.ElementAt(i).Tipo);
            }
        }

        public void limpiar() {
            this.lstFono.Items.Clear();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            TelefonoCC fonoAgregar = new TelefonoCC();
            fonoAgregar.IdPersona = this.persona;
            fonoAgregar.Numero = int.Parse(textBox1.Text);
            string tip = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            fonoAgregar.Tipo = tip;
            if (this.persona.Id != -1)
            {
                fonoAgregar.insertar();
            }
            else {
                this.listTelefonoAdd.Add(fonoAgregar);
            }
            limpiar();
            cargarTelefonos();
        }

        private int obtenerNum(string texto) {
            if (texto.Equals("")) return -1;
            string resp = "";
            Char delimitador = '-';
            String[] substrings = texto.Split(delimitador);
            resp = substrings[0];
            return int.Parse(resp);
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            int numeroBorrar = obtenerNum((lstFono.SelectedItem).ToString());
            if (numeroBorrar == -1) return;
            if (this.persona.Id != -1)
            {
                TelefonoCC numeroEliminar = new TelefonoCC();
                numeroEliminar.obtenerPorNumero(numeroBorrar);
                numeroEliminar.eliminar();
            }
            else
            {
                int n = -1;
                for (int i = 0; i < listTelefonoAdd.Count; i++){
                    if (listTelefonoAdd.ElementAt(i).Numero == numeroBorrar) n = i;
                }
                if (n!=-1) this.listTelefonoAdd.RemoveAt(n);
            }
            limpiar();
            cargarTelefonos();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pBxBorrarTF_Click(object sender, EventArgs e)
        {
            int numeroBorrar = obtenerNum((lstFono.SelectedItem).ToString());
            if (numeroBorrar == -1) return;
            if (this.persona.Id != -1)
            {
                TelefonoCC numeroEliminar = new TelefonoCC();
                numeroEliminar.obtenerPorNumero(numeroBorrar);
                numeroEliminar.eliminar();
            }
            else
            {
                int n = -1;
                for (int i = 0; i < listTelefonoAdd.Count; i++)
                {
                    if (listTelefonoAdd.ElementAt(i).Numero == numeroBorrar) n = i;
                }
                if (n != -1) this.listTelefonoAdd.RemoveAt(n);
            }
            limpiar();
            cargarTelefonos();
        }

        private void pBxAgregarTF_Click(object sender, EventArgs e)
        {
            TelefonoCC fonoAgregar = new TelefonoCC();
            fonoAgregar.IdPersona = this.persona;
            fonoAgregar.Numero = int.Parse(textBox1.Text);
            string tip = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            fonoAgregar.Tipo = tip;
            if (this.persona.Id != -1)
            {
                fonoAgregar.insertar();
            }
            else
            {
                this.listTelefonoAdd.Add(fonoAgregar);
            }
            limpiar();
            cargarTelefonos();
        }
    }
}