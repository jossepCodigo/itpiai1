using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class AulaCC
    {
        private int id;
        private int capacidad;
        private string nombre;
        private int piso;
        private bool activo;

        public AulaCC()
        {
            nulo();
        }
        private void nulo()
        {
            this.id = -1;
            this.capacidad = 0;
            this.nombre = "";
            this.piso = 0;
            this.activo = false;
        }
        public void obtener(int idd) {
            List<Object> u = Aula.obtener(idd);
            llenar(u);
        }
        public void obtener(string nom)
        {
            List<Object> u = Aula.obtener(nom);
            llenar(u);
        }
        private void llenar(List<Object> u)
        {
            if (u.Count == 0)
            {
                nulo();
                return;
            }
            this.id = (int)u.ElementAt(0);
            this.capacidad = (int)u.ElementAt(1);
            this.nombre = (string)u.ElementAt(2);
            this.piso = (int)u.ElementAt(3);
            this.activo = (bool)u.ElementAt(4);
        }
        public void insertar()
        {
            Aula.insertar(this.capacidad,this.nombre,this.piso, this.activo);
            this.obtener(this.nombre);
        }

        public void update()
        {
            Aula.update(this.id, this.capacidad, this.nombre, this.piso, this.activo);
            this.obtener(this.id);
        }

        public int Id { get => id; set => id = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Piso { get => piso; set => piso = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}