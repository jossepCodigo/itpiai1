using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;

namespace CAPANEGOCIO
{
    public class KardexCC
    {
        private int idKardex;
        private EstudianteCC estObt;
        private CarreraCC carr;
        private string serieTit;
        private string numTit;
        private DateTime fechTit;
        private string estado;
        private bool activo;

        public KardexCC() {
            nulo();
        }

        private void nulo() {
            this.idKardex = -1;
            this.estObt = new EstudianteCC();
            this.carr = new CarreraCC();
            this.serieTit = "";
            this.numTit = "";
            this.fechTit = new DateTime();
            this.estado = "creado";
            this.activo = true;
        }

        public void obtenerPorId(int idk)
        {
            List<Object> u = Kardex.obtenerPorId(idk);
            llenar(u);
        }

        public void obtenerPorCodItpi(int cod)
        {
            List<Object> u = Kardex.obtenerPorCod(cod);
            llenar(u);
        }

        private void llenar(List<Object> u)
        {
            if (u.Count == 0)
            {
                nulo();
                return;
            }
            int codEst = (int)u.ElementAt(1);
            int idCarr = (int)u.ElementAt(2);
            if (cargarEst(codEst) && cargarCarr(idCarr))
            {
                this.idKardex = (int)u.ElementAt(0);
                this.serieTit = (string)u.ElementAt(3);
                this.numTit = (string)u.ElementAt(4);
                this.fechTit = (DateTime)u.ElementAt(5);
                this.estado = (string)u.ElementAt(6);
                this.activo = (bool)u.ElementAt(7);
            }
            else
            {
                this.nulo();
            }
        }

        public bool cargarEst(int cd){
            EstudianteCC obtener = new EstudianteCC();
            obtener.obtenerPorCod(cd);
            if (obtener.IdPersona.User.getTipoUser().Equals("estudiante") 
                && obtener.IdPersona.User.getActivo()){
                this.estObt = obtener;
                return true;
            }
            return false;
        }

        public bool cargarCarr(int idC) {
            CarreraCC obtener = new CarreraCC();
            obtener.obtenerPorId(idC);
            if (obtener.Activo==true){
                this.carr = obtener;
                return true;
            }
            return false;
        }

        public void insertar(){
            if (this.estObt.CodItp != -1){
                Kardex.insertar(this.estObt.CodItp,this.carr.Id,this.serieTit,this.numTit,this.fechTit,this.estado,this.activo);
                this.obtenerPorCodItpi(this.estObt.CodItp);
            }
        }

        public void update(){
            Kardex.update(this.idKardex,this.carr.Id, this.serieTit, this.numTit, this.fechTit, this.estado, this.activo);
            this.obtenerPorId(this.idKardex);
        }

        public int IdKardex { get => idKardex; set => idKardex = value; }
        public EstudianteCC EstObt { get => estObt; set => estObt = value; }
        public CarreraCC Carr { get => carr; set => carr = value; }
        public string SerieTit { get => serieTit; set => serieTit = value; }
        public string NumTit { get => numTit; set => numTit = value; }
        public DateTime FechTit { get => fechTit; set => fechTit = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}