using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class EspecialidadCC
    {
        private int id;
        private string nombre;
        public EspecialidadCC() {
            vacio();
        }

        public EspecialidadCC(int id, string nombre){
            this.id = id;
            this.nombre = nombre;
        }

        public void obtener(int i) {
            List<Object> ll = Especialidad.obtener(i);
            llenar(ll);
        }

        public void obtener(string nom){
            List<Object> ll = Especialidad.obtener(nom);
            llenar(ll);
        }

        public static List<EspecialidadCC> all(int idDoce) {
            List<EspecialidadCC> res = new List<EspecialidadCC>();
            List<Object> esps = Especialidad.all(idDoce);
            for (int i = 0; i < esps.Count; i++)
            {
                List<Object> esp = (List<Object>)esps.ElementAt(i);
                EspecialidadCC act = new EspecialidadCC((int)esp.ElementAt(0),(string)esp.ElementAt(1));
                res.Add(act);
            }
            return res;
        }

        public static List<EspecialidadCC> espDocente(int idDoc){
            List<EspecialidadCC> res = new List<EspecialidadCC>();
            List<Object> esps = Especialidad.especialidades_Docente(idDoc);
            for (int i = 0; i < esps.Count; i++){
                List<Object> esp = (List<Object>)esps.ElementAt(i);
                EspecialidadCC act = new EspecialidadCC((int)esp.ElementAt(0), 
                    (string)esp.ElementAt(1));
                res.Add(act);
            }
            return res;
        }

        public void llenar(List<Object> ll) {
            if (ll.Count == 0) {
                vacio();
                return;
            }
            this.id = (int)ll.ElementAt(0);
            this.nombre = (string)ll.ElementAt(1);
        }
        
        private void vacio() {
            this.id = -1;
            this.nombre = "";
        }

        public void insertar(){
            Especialidad.insertar(this.nombre);
            this.obtener(this.nombre);
        }

        public void eliminar() {
            Especialidad.eliminar(this.nombre);
        }

        public static void insertarED(int id, string nombre){
            EspecialidadCC esp = new EspecialidadCC();
            esp.obtener(nombre);
            Especialidad.insertarED(id,esp.id);
        }

        public static void eliminarED(int idDoce, string nombre) {
            EspecialidadCC esp = new EspecialidadCC();
            esp.obtener(nombre);
            Especialidad.eliminarED(idDoce,esp.id);
        }

        public void setID(int i) { this.id = i; }
        public void setNombre(string nom) { this.nombre = nom; }
        public int getID() { return this.id; }
        public string getNombre() { return this.nombre; }
    }
}
