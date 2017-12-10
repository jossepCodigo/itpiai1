using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class CarreraCC
    {
        private int id;
        private string nombre;
        private string modalidad;
        private int duracion;
        private bool activo;

        public CarreraCC() {
            nulo();
        }
        private void nulo() {
            this.id = -1;
            this.nombre = "";
            this.modalidad = "";
            this.duracion = 0;
            this.activo = true;
        }
        public void obtenerPorId(int idCarr)
        {
            List<Object> u = Carrera.obtenerCarrId(idCarr);
            llenar(u);
        }
        public void obtenerPorNomb(string nom)
        {
            List<Object> u = Carrera.obtenerCarrNom(nom);
            llenar(u);
        }
        public static List<CarreraCC> all() {
            List<CarreraCC> res = new List<CarreraCC>();
            List<Object> carrs = Carrera.all();
            for (int i = 0; i < carrs.Count; i++){
                List<Object> carr = (List<Object>)carrs.ElementAt(i);
                CarreraCC act = new CarreraCC();
                act.id = (int)carr.ElementAt(0);
                act.nombre = (string)carr.ElementAt(1);
                act.modalidad = (string)carr.ElementAt(2);
                act.duracion = (int)carr.ElementAt(3);
                act.activo = (bool)carr.ElementAt(4);
                res.Add(act);
            }
            return res;
        }

        private void llenar(List<Object> u){
            if (u.Count == 0){
                nulo();
                return;
            }
            this.id = (int)u.ElementAt(0);
            this.nombre = (string)u.ElementAt(1);
            this.modalidad = (string)u.ElementAt(2);
            this.duracion = (int)u.ElementAt(3);
            this.activo = (bool)u.ElementAt(4);
        }

        public void insertar()
        {
            Carrera.insertar(this.nombre, this.modalidad, this.duracion, this.activo);
            this.obtenerPorNomb(this.nombre);
            CurriculaCC nuevo = new CurriculaCC();
            nuevo.IdCarrera = this;
            nuevo.Activo = true;
            nuevo.insertar();
        }
        public void update()
        {
            Carrera.update(this.id, this.nombre, this.modalidad, this.duracion, this.activo);
            this.obtenerPorId(this.id);
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}