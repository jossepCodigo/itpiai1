using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Aula
    {
        public static List<Object> obtener(string nom){
            Data c = new Data();
            string consult = "select * from aula where activo = 1 and nombre= '"+nom+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> aul = new List<Object>();
            if (res.HasRows){
                res.Read();
                aul.Add(res.GetInt32(0));
                aul.Add(res.GetInt32(1));
                aul.Add(res.GetString(2));
                aul.Add(res.GetInt32(3));
                aul.Add(res.GetBoolean(4));
            }
            res.Close();
            return aul;
        }
        public static List<Object> obtener(int idd)
        {
            Data c = new Data();
            string consult = "select * from aula where activo = 1 and id_aula="+idd;
            SqlDataReader res = c.consulta(consult);
            List<Object> aul = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                aul.Add(res.GetInt32(0));
                aul.Add(res.GetInt32(1));
                aul.Add(res.GetString(2));
                aul.Add(res.GetInt32(3));
                aul.Add(res.GetBoolean(4));
            }
            res.Close();
            return aul;
        }
        public static void insertar(int cap, string nom, int piso, bool act)
        {
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"insert into aula values("+cap+",'"+nom+"',"+piso+",1)";
            c.nonQuery(sql);
        }
        public static void update(int id, int cap, string nom, int piso, bool act)
        {
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"update aula set capacidad = "+cap+", piso="+piso+",activo="+i+" where id_aula =" +id;
            c.nonQuery(sql);
        }
    }
}