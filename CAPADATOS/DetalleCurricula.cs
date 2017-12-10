using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class DetalleCurricula
    {
        public static List<Object> obtenerPorId(int id){
            Data c = new Data();
            string consult = "select * from detalleCurricula where activo = 1 and id_det =" + id;
            SqlDataReader res = c.consulta(consult);
            List<Object> det = new List<object>();
            if (res.HasRows){
                res.Read();
                det.Add(res.GetInt32(0));
                det.Add(res.GetInt32(1));
                det.Add(res.GetInt32(2));
                det.Add(res.GetInt32(3));
                det.Add(res.GetBoolean(4));
            }
            res.Close();
            return det;
        }

        public static List<Object> obtener(int idC, int idM,int niv){
            Data c = new Data();
            string consult = "select * from detalleCurricula where activo = 1 and id_curricula =" + idC + " and id_materia =" + idM + " and nivel ="+niv;
            SqlDataReader res = c.consulta(consult);
            List<Object> det = new List<object>();
            if (res.HasRows){
                res.Read();
                det.Add(res.GetInt32(0));
                det.Add(res.GetInt32(1));
                det.Add(res.GetInt32(2));
                det.Add(res.GetInt32(3));
                det.Add(res.GetBoolean(4));
            }
            res.Close();
            return det;
        }

        public static List<Object> allPorCurr(int id){
            Data c = new Data();
            string consult = "select * from detalleCurricula where activo = 1 and id_curricula ="+id+" order by nivel asc";
            SqlDataReader res = c.consulta(consult);
            List<Object> dets = new List<Object>();
            if (res.HasRows){
                while (res.Read()){
                    List<Object> dt = new List<object>();
                    dt.Add(res.GetInt32(0));
                    dt.Add(res.GetInt32(1));
                    dt.Add(res.GetInt32(2));
                    dt.Add(res.GetInt32(3));
                    dt.Add(res.GetBoolean(4));
                    dets.Add(dt);
                }
            }
            res.Close();
            return dets;
        }
        public static void insertar(int idCurr,int idMat,int niv)
        {
            Data c = new Data();
            string sql = @"insert into detalleCurricula values("+idCurr+","+idMat+","+niv+",1);";
            c.nonQuery(sql);
        }

        public static void update(int id, int niv, bool act)
        {
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"update detalleCurricula set nivel="+niv+",activo="+i+" where id_det="+id;
            c.nonQuery(sql);
        }
    }
}