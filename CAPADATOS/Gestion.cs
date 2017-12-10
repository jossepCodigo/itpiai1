using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Gestion
    {
        public static List<Object> obtenerPorId(int id){
            Data c = new Data();
            string consult = @"select * from gestion where id_gestion ="+id;
            SqlDataReader res = c.consulta(consult);
            List<Object> gest = new List<Object>();
            if (res.HasRows){
                res.Read();
                gest.Add(res.GetInt32(0));
                gest.Add(res.GetInt32(1));
                gest.Add(res.GetInt32(2));
                gest.Add(res.GetDateTime(3));
                gest.Add(res.GetDateTime(4));
                gest.Add(res.GetString(5));
                gest.Add(res.GetBoolean(6));
            }
            res.Close();
            return gest;
        }
        public static List<Object> obtener(int num,int año,string mod){
            Data c = new Data();
            string consult = @"select * from gestion where numero="+num+" and año="+año+" and modalidad='"+mod+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> gest = new List<Object>();
            if (res.HasRows){
                res.Read();
                gest.Add(res.GetInt32(0));
                gest.Add(res.GetInt32(1));
                gest.Add(res.GetInt32(2));
                gest.Add(res.GetDateTime(3));
                gest.Add(res.GetDateTime(4));
                gest.Add(res.GetString(5));
                gest.Add(res.GetBoolean(6));
            }
            res.Close();
            return gest;
        }
        public static List<Object> obtenerActivo(string mod){
            Data c = new Data();
            string consult = @"select * from gestion where modalidad='"+mod+"' and activo=1";
            SqlDataReader res = c.consulta(consult);
            List<Object> gest = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                gest.Add(res.GetInt32(0));
                gest.Add(res.GetInt32(1));
                gest.Add(res.GetInt32(2));
                gest.Add(res.GetDateTime(3));
                gest.Add(res.GetDateTime(4));
                gest.Add(res.GetString(5));
                gest.Add(res.GetBoolean(6));
            }
            res.Close();
            return gest;
        }
        public static List<Object> obtenerActivo()
        {
            Data c = new Data();
            string consult = "select * from gestion where activo=1";
            SqlDataReader res = c.consulta(consult);
            List<Object> gests = new List<object>();
            if (res.HasRows){
                while (res.Read()){
                    List<Object> gest = new List<object>();
                    gest.Add(res.GetInt32(0));
                    gest.Add(res.GetInt32(1));
                    gest.Add(res.GetInt32(2));
                    gest.Add(res.GetDateTime(3));
                    gest.Add(res.GetDateTime(4));
                    gest.Add(res.GetString(5));
                    gest.Add(res.GetBoolean(6));
                    gests.Add(gest);
                }
            }
            res.Close();
            return gests;
        }

        public static bool existeActivo(string mod) {
            Data c = new Data();
            string consult = "select * from gestion where activo = 1 and modalidad = '"+mod+"'";
            SqlDataReader res = c.consulta(consult);
            if (res.HasRows){
                return true;
            }
            res.Close();
            return false;
        }

        public static void insertar(int num,int año,DateTime fechaIni,DateTime fechaFin,
            string mod, bool act){
            string fI = fechaIni.ToString(@"MM/dd/yy");
            string fF = fechaFin.ToString(@"MM/dd/yy");
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string cancel = @"update gestion set activo=0 where modalidad='anual'";
            string sql = @"insert into gestion values("+num+","+año+",'"+fI+"','"+fF+
                "','"+mod+"',"+i+")";
            c.nonQuery(cancel);
            c.nonQuery(sql);
        }
        public static void update(int id, DateTime fechaIni, DateTime fechaFin, bool act){
            string fI = fechaIni.ToString(@"MM/dd/yy");
            string fF = fechaFin.ToString(@"MM/dd/yy");
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"update gestion set fechaIni='"+fI+"', fechaFin='"+fF+"', activo="
                +i+" where id_gestion="+id;
            c.nonQuery(sql);
        }
    }
}