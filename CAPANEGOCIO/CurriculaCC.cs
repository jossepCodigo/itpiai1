using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class CurriculaCC
    {
        private int id;
        private CarreraCC idCarrera;
        private bool activo;

        public CurriculaCC() {
            nulo();
        }
        private void nulo() {
            this.id = -1;
            this.idCarrera = new CarreraCC();
            this.activo = false;
        }
        private void cargar(List<Object> u) {
            if (u.Count == 0){
                nulo();
                return;
            }
            int idCarr = (int)u.ElementAt(1);
            if (cargarCarrera(idCarr)){
                this.id = (int)u.ElementAt(0);
                this.activo = (bool)u.ElementAt(2);
            }
        }
        private bool cargarCarrera(int idc) {
            CarreraCC obtCarr = new CarreraCC();
            obtCarr.obtenerPorId(idc);
            if (obtCarr.Id != -1) {
                this.idCarrera = obtCarr;
                return true;
            }
            return false;
        }
        public List<string> detalleMateria(){
            List<string> res = new List<string>();
            List<DetalleCurriculaCC> lista = DetalleCurriculaCC.detMatCurr(this.id);
            for (int i = 0; i < lista.Count; i++){
                res.Add(lista.ElementAt(i).Nivel+" "+lista.ElementAt(i).Id_materia.Nombre);
            }
            return res;
        }
        public void obtenerPorId(int idd) {
            List<Object> u = Curricula.obtenerPorId(idd);
            cargar(u);
        }
        public void obtenerPorNomCarr(string carr) {
            List<Object> u = Curricula.obtenerPorCarrera(carr);
            cargar(u);
        }

        public void insertar()
        {
            Curricula.insertar(this.idCarrera.Id);
            this.obtenerPorNomCarr(this.idCarrera.Nombre);
        }
        public void update()
        {
            Curricula.update(this.id, this.activo);
            this.obtenerPorId(this.id);
        }

        public int Id { get => id; set => id = value; }
        public CarreraCC IdCarrera { get => idCarrera; set => idCarrera = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}