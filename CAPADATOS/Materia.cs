using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS{
    public class Materia{
        public static List<Object> obtenerPorId(int id){
            Data c = new Data();
            string consult = "select * from materia where materia.id_materia ="+id;
            SqlDataReader res = c.consulta(consult);
            List<Object> mat = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                mat.Add(res.GetInt32(0));
                mat.Add(res.GetString(1));
                mat.Add(res.GetString(2));
                mat.Add(res.GetInt32(3));
                mat.Add(res.GetBoolean(4));
            }
            res.Close();
            return mat;
        }
        public static List<Object> obtenerPorSig(string sig) {
            Data c = new Data();
            string consult = @"select * from materia where materia.sigla = '"+sig+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> mat = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                mat.Add(res.GetInt32(0));
                mat.Add(res.GetString(1));
                mat.Add(res.GetString(2));
                mat.Add(res.GetInt32(3));
                mat.Add(res.GetBoolean(4));
            }
            res.Close();
            return mat;
        }
        public static List<Object> obtenerPorNom(string nomb){
            Data c = new Data();
            string consult = @"select * from materia where materia.nombre = '"+nomb+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> mat = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                mat.Add(res.GetInt32(0));
                mat.Add(res.GetString(1));
                mat.Add(res.GetString(2));
                mat.Add(res.GetInt32(3));
                mat.Add(res.GetBoolean(4));
            }
            res.Close();
            return mat;
        }

        public static List<Object> all(){
            Data c = new Data();
            string consult = "select * from materia where activo = 1";
            SqlDataReader res = c.consulta(consult);
            List<Object> mats = new List<object>();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    List<Object> mat = new List<object>();
                    mat.Add(res.GetInt32(0));
                    mat.Add(res.GetString(1));
                    mat.Add(res.GetString(2));
                    mat.Add(res.GetInt32(3));
                    mat.Add(res.GetBoolean(4));
                    mats.Add(mat);
                }
            }
            res.Close();
            return mats;
        }

        public static void insertar(string sig, string mat, int cargh, bool act){
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"insert into materia values('"+sig+"','"+mat+"',"+cargh+","+i+")";
            c.nonQuery(sql);
        }

        public static void update(int id, string sig, string nom, int cargh, bool act){
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"update materia set sigla='"+sig+"', nombre = '"+nom+"', carga_horaria = "+cargh+" , activo= "+i+" where id_materia ="+id;
            c.nonQuery(sql);
        }
    }
}