using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class DocenteCC{
        private int id;
        private PersonaCC idPersona;
        private DateTime fechaIngreso;
        private string imagen;

        public DocenteCC(){
            this.nulo();
        }

        public void obtenerPorId(int idDoc){
            List<Object> u = Docente.obtenerDocId(idDoc);
            llenar(u);
        }

        public void obtenerPorCi(int ci){
            List<Object> u = Docente.obtenerDocCi(ci);
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
                this.fechaIngreso = (DateTime)u.ElementAt(2);
                this.imagen = (string)u.ElementAt(3);
            }else {
                this.nulo();
            }
        }

        private void nulo() {
            this.id = -1;
            this.idPersona = new PersonaCC();
            this.fechaIngreso = new DateTime();
            this.imagen = "";
        }

        public bool cargarPers(int idPers){
            PersonaCC obtener = new PersonaCC();
            obtener.obtenerPersonId(idPers);
            if (obtener.User.getTipoUser().Equals("docente") && obtener.User.getActivo()){
                this.idPersona = obtener;
                return true;
            }
            return false;
        }

        public void insertar(){
            if (this.idPersona.Id != -1){
                Docente.insertar(this.idPersona.Id,this.fechaIngreso,this.imagen);
                this.obtenerPorCi(this.idPersona.Ci);
            }
        }

        public void update(){
            Docente.update(this.id, this.fechaIngreso, this.imagen);
            this.obtenerPorId(this.id);
        }

        public int Id { get => id; set => id = value; }
        public PersonaCC IdPersona { get => idPersona; set => idPersona = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}