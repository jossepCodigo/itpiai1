using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class AdminstradorCC
    {
        private int id;
        private PersonaCC idPersona;
        private string cargo;
        private string imagen;

        public AdminstradorCC(){
            this.nulo();
        }

        public void obtenerPorId(int idDoc){
            List<Object> u = Administrador.obtenerDocId(idDoc);
            llenar(u);
        }

        public void obtenerPorCi(int ci){
            List<Object> u = Administrador.obtenerDocCi(ci);
            llenar(u);
        }

        private void llenar(List<Object> u){
            if (u.Count == 0){
                nulo();
                return;
            }
            int idPersonas = (int)u.ElementAt(1);
            if (cargarPers(idPersonas)){
                this.id = (int)u.ElementAt(0);
                this.cargo = (string)u.ElementAt(2);
                this.imagen = (string)u.ElementAt(3);
            }else{
                this.nulo();
            }
        }

        private void nulo(){
            this.id = -1;
            this.idPersona = new PersonaCC();
            this.cargo = "";
            this.imagen = "";
        }

        public bool cargarPers(int idPers){
            PersonaCC obtener = new PersonaCC();
            obtener.obtenerPersonId(idPers);
            if (obtener.User.getTipoUser().Equals("administrador") && obtener.User.getActivo()){
                this.idPersona = obtener;
                return true;
            }
            return false;
        }

        public void insertar(){
            if (this.idPersona.Id != -1){
                Administrador.insertar(this.idPersona.Id, this.cargo, this.imagen);
                this.obtenerPorCi(this.idPersona.Ci);
            }
        }

        public void update(){
            Administrador.update(this.id, this.cargo, this.imagen);
            this.obtenerPorId(this.id);
        }

        public int Id { get => id; set => id = value; }
        public PersonaCC IdPersona { get => idPersona; set => idPersona = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}