using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class DetalleCurriculaCC
    {
        private int id;
        private CurriculaCC id_curricula;
        private MateriaCC id_materia;
        private int nivel;
        private bool activo;

        public DetalleCurriculaCC() {
            nulo();
        }

        public void obtenerPorId(int id) {
            List<Object> u = DetalleCurricula.obtenerPorId(id);
            cargar(u);
        }

        public void obtenerPorCM(int idC, int idM,int niv) {
            List<Object> u = DetalleCurricula.obtener(idC,idM,niv);
            cargar(u);
        }

        public static List<DetalleCurriculaCC> detMatCurr(int idC) {
            List<DetalleCurriculaCC> resp = new List<DetalleCurriculaCC>();
            List<Object> dets = DetalleCurricula.allPorCurr(idC);
            for (int i = 0; i < dets.Count; i++)
            {
                List<Object> detalle = (List<Object>)dets.ElementAt(i);
                DetalleCurriculaCC act = new DetalleCurriculaCC();
                int idd = (int)detalle.ElementAt(0);
                act.obtenerPorId(idd);
                resp.Add(act);
            }
            return resp;
        }

        public void insertar()
        {
            DetalleCurricula.insertar(this.id_curricula.Id,this.id_materia.Id,this.nivel);
            this.obtenerPorCM(this.id_curricula.Id,this.id_materia.Id,this.nivel);
        }

        public void update()
        {
            DetalleCurricula.update(this.id, this.nivel, this.activo);
            this.obtenerPorId(this.id);
        }
        /////////////////////////// procesos internos
        private void nulo() {
            this.id = -1;
            this.id_curricula = new CurriculaCC();
            this.id_materia = new MateriaCC();
            this.nivel = 0;
            this.activo = true;
        }

        private void cargar(List<Object> u){
            if (u.Count == 0)
            {
                nulo();
                return;
            }
            int idCurr = (int)u.ElementAt(1);
            int idMat = (int)u.ElementAt(2);
            if (cargarCurr(idCurr) && cargarMat(idMat))
            {
                this.id = (int)u.ElementAt(0);
                this.nivel = (int)u.ElementAt(3);
                this.activo = (bool)u.ElementAt(4);
            }
        }

        private bool cargarCurr(int idc)
        {
            CurriculaCC obtCurr = new CurriculaCC();
            obtCurr.obtenerPorId(idc);
            if (obtCurr.Id != -1)
            {
                this.Id_curricula = obtCurr;
                return true;
            }
            return false;
        }

        private bool cargarMat(int idm)
        {
            MateriaCC obtMat = new MateriaCC();
            obtMat.obtenerPorId(idm);
            if (obtMat.Id != -1)
            {
                this.Id_materia = obtMat;
                return true;
            }
            return false;
        }

        public int Id { get => id; set => id = value; }
        public CurriculaCC Id_curricula { get => id_curricula; set => id_curricula = value; }
        public MateriaCC Id_materia { get => id_materia; set => id_materia = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}