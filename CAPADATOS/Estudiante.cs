using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Estudiante
    {
        public static List<Object> obtenerPorCod(int idDoc){
            Data c = new Data();
            string consult = "select * from estudiante where cod_itpiai="+idDoc;
            SqlDataReader res = c.consulta(consult);
            List<Object> est = new List<Object>();
            if (res.HasRows){
                res.Read();
                est.Add(res.GetInt32(0));
                est.Add(res.GetInt32(1));
                est.Add(res.GetInt32(2));
                est.Add(res.GetString(3));
            }
            res.Close();
            return est;
        }

        public static List<Object> obtenerEstCi(int ci){
            Data c = new Data();
            string consult = "select estudiante.cod_itpiai,estudiante.id_persona,estudiante.añoIng,estudiante.imagen from estudiante,persona where estudiante.id_persona = persona.id_persona and persona.ci =" + ci;
            SqlDataReader res = c.consulta(consult);
            List<Object> est = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                est.Add(res.GetInt32(0));
                est.Add(res.GetInt32(1));
                est.Add(res.GetInt32(2));
                est.Add(res.GetString(3));
            }
            res.Close();
            return est;
        }
        public static void insertar(int cod, int idP, int anoI, string img){
            Data c = new Data();
            string sql = @"insert into estudiante values("+cod+","+idP+","+anoI+",'"+img+"')";
            c.nonQuery(sql);
        }
        public static void update(int cod, int anoI,string img){
            Data c = new Data();
            string sql = @"update estudiante set añoIng="+anoI+", imagen='"+img+"' where cod_itpiai="+cod;
            c.nonQuery(sql);
        }
    }
}
