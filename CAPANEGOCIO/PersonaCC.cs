using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class PersonaCC
    {
        private int id;
        private UsuarioController user;
        private int ci;
        private string nombre;
        private string apellido_p;
        private string apellido_m;
        private byte sexo;
        private string domicilio;
        private string correo;
        private string nacionalidad;
        private DateTime nacimiento;

        public PersonaCC() {
            this.nulo();
        }

        public void obtenerPersonId(int idObt) {
            List<Object> u = Persona.obtenerPerId(idObt);
            llenar(u);
        }
        public void obtenerPersonCi(int ci1)
        {
            List<Object> u = Persona.obtenerPerCi(ci1);
            llenar(u);
        }

        public void cargarUs(int idOb) {
            UsuarioController obtener = new UsuarioController();
            obtener.obtenerUsuario(idOb);
            this.user = obtener;
        }

        private void llenar(List<Object> u)
        {
            if (u.Count == 0)
            {
                nulo();
                return;
            }
            this.id = (int)u.ElementAt(0);
            int idU = (int)u.ElementAt(1);
            cargarUs(idU);
            this.ci = (int)u.ElementAt(2);
            this.nombre = (string)u.ElementAt(3);
            this.apellido_p = (string)u.ElementAt(4);
            this.apellido_m = (string)u.ElementAt(5);
            this.sexo = (byte)u.ElementAt(6);
            this.domicilio = (string)u.ElementAt(7);
            this.correo = (string)u.ElementAt(8);
            this.nacionalidad = (string)u.ElementAt(9);
            this.nacimiento = (DateTime)u.ElementAt(10);
        }

        private void nulo() {
            this.id = -1;
            this.user = new UsuarioController();
            this.ci = 0;
            this.nombre = "";
            this.apellido_p = "";
            this.apellido_m = "";
            this.sexo = 2;
            this.domicilio = "";
            this.correo = "";
            this.nacionalidad = "";
            this.nacimiento = new DateTime();
        }

        public void insertar() { 
            if (user.getID()!=-1)
            {
                Persona.insertar(this.user.getID(),this.ci, this.nombre,this.apellido_p,
                    this.apellido_m,this.sexo,this.domicilio,this.correo,this.nacionalidad,
                    this.nacimiento);
                this.obtenerPersonCi(this.ci);
            }
        }

        public void update()
        {
            Persona.update(this.id, this.ci, this.nombre, this.apellido_p,
                    this.apellido_m, this.sexo, this.domicilio, this.correo, this.nacionalidad,
                    this.nacimiento);
        }

        public int Id { get => id; set => id = value; }
        public UsuarioController User { get => user; set => user = value; }
        public int Ci { get => ci; set => ci = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public byte Sexo { get => sexo; set => sexo = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
    }
}