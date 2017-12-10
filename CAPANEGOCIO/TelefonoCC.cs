using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class TelefonoCC
    {
        private int id;
        private PersonaCC idPersona;
        private int numero;
        private string tipo;

        public TelefonoCC(){
            this.nulo();
        }

        public TelefonoCC(int id, PersonaCC idPersona, int numero, string tipo)
        {
            this.id = id;
            this.idPersona = idPersona;
            this.numero = numero;
            this.tipo = tipo;
        }

        public void eliminar() {
            if (id!=-1)
            {
                Telefono.eliminar(this.id);
            }
        }

        public void insertar() {
            if (idPersona.Id != -1)
            {
                Telefono.insertar(this.idPersona.Id,this.numero,this.tipo);
                this.obtenerPorNumero(this.numero);
            }
        }

        public void obtenerPorNumero(int num) {
            List<Object> u = Telefono.obtenerPorN(num);
            llenar(u);
        }

        private void llenar(List<Object> u)
        {
            if (u.Count == 0){
                nulo();
                return;
            }
            this.id = (int)u.ElementAt(0);
            int idP = (int)u.ElementAt(1);
            cargarP(idP);
            this.numero = (int)u.ElementAt(2);
            this.tipo = (string)u.ElementAt(3);
        }

        private void nulo() {
            this.id = -1;
            this.IdPersona = new PersonaCC();
            this.numero = 0;
            this.tipo = "";
        }

        public void cargarP(int idP)
        {
            PersonaCC obtener = new PersonaCC();
            obtener.obtenerPersonId(idP);
            this.idPersona = obtener;
        }

        public static List<TelefonoCC> telefonoPersona(int id) {
            if (id == -1) return new List<TelefonoCC>();
            List<Object> todos = Telefono.obtenerTelefonoPersona(id);
            List<TelefonoCC> telefs = new List<TelefonoCC>();
            for (int i = 0; i < todos.Count; i++)
            {
                List<object> fon = (List<object>)todos.ElementAt(i);
                PersonaCC pp = new PersonaCC();
                pp.obtenerPersonId((int)fon.ElementAt(1));
                TelefonoCC actual = new TelefonoCC((int)fon.ElementAt(0),
                    pp,(int)fon.ElementAt(2),(string)fon.ElementAt(3));
                telefs.Add(actual);
            }
            return telefs;
        }

        public int Id { get => id; set => id = value; }
        public PersonaCC IdPersona { get => idPersona; set => idPersona = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}