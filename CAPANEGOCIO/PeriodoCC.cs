using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPADATOS;
namespace CAPANEGOCIO
{
    public class PeriodoCC
    {
        private int id;
        private int materiaProg;
        private int aula;
        private string dia;
        private DateTime horaIni;
        private TimeSpan horaFin;

        public PeriodoCC() {
            nulo();
        }
        private void nulo() {
            this.id = -1;
            this.materiaProg = -1;
            this.aula = -1;
            this.dia = "";
            this.horaIni = new DateTime();
            this.horaFin = new TimeSpan();
        }

    }
}