using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class EstudianteCC
    {
        private int codItp;
        private PersonaCC idPersona;
        private int añoIng;
        private string imagen;

        public EstudianteCC() {
            nulo();
        }
        private void nulo() {
            this.codItp = -1;
            this.idPersona = new PersonaCC();
            this.añoIng = 0;
            this.imagen = "";
        }
        public void obtenerPorCod(int cod){
            List<Object> u = Estudiante.obtenerPorCod(cod);
            llenar(u);
        }

        public void obtenerPorCi(int ci){
            List<Object> u = Estudiante.obtenerEstCi(ci);
            llenar(u);
        }

        private void llenar(List<Object> u)
        {
            if (u.Count == 0){
                nulo();
                return;
            }
            int idPersonas = (int)u.ElementAt(1);
            if (cargarPers(idPersonas)){
                this.codItp = (int)u.ElementAt(0);
                this.añoIng = (int)u.ElementAt(2);
                this.imagen = (string)u.ElementAt(3);
            }
            else{
                this.nulo();
            }
        }

        public bool cargarPers(int idPers)
        {
            PersonaCC obtener = new PersonaCC();
            obtener.obtenerPersonId(idPers);
            if (obtener.User.getTipoUser().Equals("estudiante") && obtener.User.getActivo()){
                this.idPersona = obtener;
                return true;
            }
            return false;
        }

        public void insertar(){
            if (this.idPersona.Id != -1){
                Estudiante.insertar(this.codItp,this.idPersona.Id,this.añoIng,this.imagen);
                this.obtenerPorCi(this.idPersona.Ci);
            }
        }

        public void update(){
            Estudiante.update(this.codItp, this.idPersona.Id, this.imagen);
            this.obtenerPorCod(this.codItp);
        }

        public int CodItp { get => codItp; set => codItp = value; }
        public PersonaCC IdPersona { get => idPersona; set => idPersona = value; }
        public int AñoIng { get => añoIng; set => añoIng = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}