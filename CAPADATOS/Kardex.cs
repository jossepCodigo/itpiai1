using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Kardex
    {
        public Kardex() {
            
        }

        public static List<Object> obtenerPorId(int id){
            Data c = new Data();
            string consult = "select * from kardex where id_Kardex ="+id;
            SqlDataReader res = c.consulta(consult);
            List<Object> kar = new List<Object>();
            if (res.HasRows){
                res.Read();
                kar.Add(res.GetInt32(0));
                kar.Add(res.GetInt32(1));
                kar.Add(res.GetInt32(2));
                kar.Add(res.GetString(3));
                kar.Add(res.GetString(4));
                kar.Add(res.GetDateTime(5));
                kar.Add(res.GetString(6));
                kar.Add(res.GetBoolean(7));
            }
            res.Close();
            return kar;
        }

        public static List<Object> obtenerPorCod(int id){
            Data c = new Data();
            string consult = @"select * from kardex where cod_itpiai=" + id;
            SqlDataReader res = c.consulta(consult);
            List<Object> kar = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                kar.Add(res.GetInt32(0));
                kar.Add(res.GetInt32(1));
                kar.Add(res.GetInt32(2));
                kar.Add(res.GetString(3));
                kar.Add(res.GetString(4));
                kar.Add(res.GetDateTime(5));
                kar.Add(res.GetString(6));
                kar.Add(res.GetBoolean(7));
            }
            res.Close();
            return kar;
        }

        public static void insertar(int codItp, int idCarr, string serieT, string numT, 
            DateTime fT, string estd, bool at)
        {
            string fechaT = fT.ToString(@"MM/dd/yy");
            int act = 0;
            if (at) act=1;
            Data c = new Data();
            string sql = @"insert into kardex values("+codItp+","+idCarr+",'"+serieT+
                "','"+numT+"','"+fechaT+"','"+estd+"',"+act+")";
            c.nonQuery(sql);
        }

        public static void update(int idk, int idC,string serieT,string numT,DateTime fT,string est, bool at){
            string fechT = fT.ToString(@"MM/dd/yy");
            int act = 0;
            if (at) act = 1;
            Data c = new Data();
            string sql = @"update kardex set id_carrera="+idC+",serie_tit_b='"+serieT+"',numero_tit_b="+numT+
                ",fecha_tit_b='"+fechT+"',estado='"+est+"',activo="+act+" where id_Kardex="+idk;
            c.nonQuery(sql);
        }
    }
}