using CAPADATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPANEGOCIO
{
    public class UsuarioController
    {
        private int id_usuario;
        private string username;
        private string passwords;
        private string tipo_usuario;
        private bool activo;
        private int intentos;

        public UsuarioController() {
            this.nulo();
        }

        public void obtenerUsuario(int idObt){
            List<Object> u = Usuario.obtenerUs(idObt);
            llenar(u);
        }

        public void obtenerUsuario(string us, string pass){
            List<Object> u = Usuario.obtenerUs(us,pass);
            llenar(u);
        }

        public void obtenerUsuario(string us)
        {
            List<Object> u = Usuario.obtenerUs(us);
            llenar(u);
        }
        
        public void insertar(){
            Usuario.insertar(this.username,this.passwords,this.tipo_usuario,this.activo,
                this.intentos);
            this.obtenerUsuario(this.username,this.passwords);
        }

        public void update(){
            Usuario.update(this.id_usuario,this.username,this.passwords,this.tipo_usuario,
                this.activo,this.intentos);
        }

        private void llenar(List<Object> u){
            if (u.Count == 0) {
                nulo();
                return;
            }
            this.id_usuario=(int)u.ElementAt(0);
            this.username=(string)u.ElementAt(1);
            this.passwords=(string)u.ElementAt(2);
            this.tipo_usuario=(string)u.ElementAt(3);
            this.activo=(bool)u.ElementAt(4);
            this.intentos=(int)u.ElementAt(5);
        }

        private void nulo() {
            this.id_usuario = -1;
            this.username = "";
            this.passwords = "";
            this.tipo_usuario = "";
            this.activo = true;
            this.intentos = 0;
        }

        public void aumentarInt() {
            this.intentos++;
            this.update();
        }

        public void desbloquear() {
            this.intentos = 0;
            this.update();
        }

        public static bool existe(string us) {
            return Usuario.existe(us);
        }

        public void setID(int id) {this.id_usuario = id;}
        public void setUserName(string u) {this.username = u;}
        public void setPasswords(string pass) {this.passwords = pass;}
        public void setTipoUser(string tipo) {this.tipo_usuario = tipo;}
        public void setActivo(bool act) {this.activo = act;}
        public void setIntentos(int i) { this.intentos =i; }
        public int getID() {return this.id_usuario;}
        public string getUserName() {return this.username;}
        public string getPasswords() {return this.passwords;}
        public string getTipoUser() {return this.tipo_usuario;}
        public bool getActivo() { return this.activo; }
        public int getIntentos() { return this.intentos; }
    }
}