using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class GestionCC
    {
        private int id;
        private int numero;
        private int año;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private string modalidad;
        private bool activo;

        public GestionCC() {
            nulo();
        }
        private void nulo(){
            this.id = -1;
            this.numero = -1;
            this.año = -1;
            this.fechaIni = new DateTime();
            this.fechaFin = new DateTime();
            this.modalidad = "semestral";
            this.activo = true;
        }
        public void obtenerPorId(int idG){
            List<Object> u = Gestion.obtenerPorId(idG);
            llenar(u);
        }
        public void obtener(int num,int año, string modo){
            List<Object> u = Gestion.obtener(num,año,modo);
            llenar(u);
        }
        public void obtenerActivo(string mod){
            List<Object> u = Gestion.obtenerActivo(mod);
            llenar(u);
        }
        public static List<GestionCC> allActivo(){
            List<GestionCC> res = new List<GestionCC>();
            List<Object> gests = Gestion.obtenerActivo();
            for (int i = 0; i < gests.Count; i++){
                List<Object> ges = (List<Object>)gests.ElementAt(i);
                GestionCC act = new GestionCC();
                act.id = (int)ges.ElementAt(0);
                act.numero = (int)ges.ElementAt(1);
                act.año = (int)ges.ElementAt(2);
                act.fechaIni = (DateTime)ges.ElementAt(3);
                act.fechaFin = (DateTime)ges.ElementAt(4);
                act.modalidad = (string)ges.ElementAt(5);
                act.activo = (bool)ges.ElementAt(6);
                res.Add(act);
            }
            return res;
        }
        public static bool existeActivo(string mod) {
            return Gestion.existeActivo(mod);
        }
        private void llenar(List<Object> u){
            if (u.Count == 0){
                nulo();
                return;
            }
            this.id = (int)u.ElementAt(0);
            this.numero = (int)u.ElementAt(1);
            this.año = (int)u.ElementAt(2);
            this.fechaIni = (DateTime)u.ElementAt(3);
            this.fechaFin = (DateTime)u.ElementAt(4);
            this.modalidad = (string)u.ElementAt(5);
            this.activo = (bool)u.ElementAt(6);
        }
        public void insertar(){
            Gestion.insertar(this.numero,this.año,this.fechaIni,this.fechaFin,
                this.modalidad,this.activo);
            this.obtener(this.numero,this.año,this.modalidad);
        }
        public void update(){
            Gestion.update(this.id,this.fechaIni,this.fechaFin,this.activo);
            this.obtenerPorId(this.id);
        }

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Año { get => año; set => año = value; }
        public DateTime FechaIni { get => fechaIni; set => fechaIni = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}