using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class MateriaCC
    {
        private int id;
        private string sigla;
        private string nombre;
        private int carga_h;
        private bool activo;

        public MateriaCC()
        {
            nulo();
        }
        private void nulo()
        {
            this.id = -1;
            this.sigla = "";
            this.nombre = "";
            this.carga_h = 0;
            this.activo = true;
        }
        public void obtenerPorSigla(string sig) {
            List<Object> u = Materia.obtenerPorSig(sig);
            llenar(u);
        }
        public void obtenerPorId(int idMat)
        {
            List<Object> u = Materia.obtenerPorId(idMat);
            llenar(u);
        }
        public void obtenerPorNomb(string nom)
        {
            List<Object> u = Materia.obtenerPorNom(nom);
            llenar(u);
        }
        public static List<MateriaCC> all()
        {
            List<MateriaCC> res = new List<MateriaCC>();
            List<Object> mats = Materia.all();
            for (int i = 0; i < mats.Count; i++)
            {
                List<Object> mat = (List<Object>)mats.ElementAt(i);
                MateriaCC act = new MateriaCC();
                act.id = (int)mat.ElementAt(0);
                act.sigla = (string)mat.ElementAt(1);
                act.nombre = (string)mat.ElementAt(2);
                act.carga_h = (int)mat.ElementAt(3);
                act.activo = (bool)mat.ElementAt(4);
                res.Add(act);
            }
            return res;
        }

        private void llenar(List<Object> u)
        {
            if (u.Count == 0)
            {
                nulo();
                return;
            }
            this.id = (int)u.ElementAt(0);
            this.sigla = (string)u.ElementAt(1);
            this.nombre = (string)u.ElementAt(2);
            this.carga_h = (int)u.ElementAt(3);
            this.activo = (bool)u.ElementAt(4);
        }

        public void insertar()
        {
            Materia.insertar(this.sigla, this.nombre, this.carga_h, this.activo);
            this.obtenerPorNomb(this.nombre);
        }
        public void update()
        {
            Materia.update(this.id, this.sigla, this.nombre, this.carga_h, this.activo);
            this.obtenerPorId(this.id);
        }

        public int Id { get => id; set => id = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Carga_h { get => carga_h; set => carga_h = value; }
        public bool Activo { get => activo; set => activo = value; }

    }
}