using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Curricula
    {
        public static List<Object> obtenerPorId(int id){
            Data c = new Data();
            string consult = "select * from curricula where id_carrera =" + id;
            SqlDataReader res = c.consulta(consult);
            List<Object> curr = new List<Object>();
            if (res.HasRows){
                res.Read();
                curr.Add(res.GetInt32(0));
                curr.Add(res.GetInt32(1));
                curr.Add(res.GetBoolean(2));
            }
            res.Close();
            return curr;
        }
        public static List<Object> obtenerPorCarrera(string carr)
        {
            Data c = new Data();
            string consult = "select * from curricula,carrera where curricula.activo=1 and curricula.id_carrera=carrera.id_carrera and carrera.activo = 1 and carrera.nombre = '"+carr+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> curr = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                curr.Add(res.GetInt32(0));
                curr.Add(res.GetInt32(1));
                curr.Add(res.GetBoolean(2));
            }
            res.Close();
            return curr;
        }
        public static List<Object> obtenerAct(){
            Data c = new Data();
            string consult = "select* from curricula where activo = 1";
            SqlDataReader res = c.consulta(consult);
            List<Object> curr = new List<Object>();
            if (res.HasRows){
                res.Read();
                curr.Add(res.GetInt32(0));
                curr.Add(res.GetInt32(1));
                curr.Add(res.GetBoolean(2));
            }
            res.Close();
            return curr;
        }
        public static List<Object> detalleMat(int curr){
            Data c = new Data();
            string consult = "select nombre from detalleCurricula,materia where detalleCurricula.id_materia=materia.id_materia and id_curricula = "+curr+" and activo = 1";
            SqlDataReader res = c.consulta(consult);
            List<Object> detalles = new List<object>();
            if (res.HasRows){
                while (res.Read()){
                    List<Object> det = new List<object>();
                    det.Add(res.GetString(0));
                    detalles.Add(det);
                }
            }
            res.Close();
            return detalles;
        }
        public static void insertar(int carr)
        {
            Data c = new Data();
            string sql = @"insert into curricula values(" + carr + ",1)";
            c.nonQuery(sql);
        }

        public static void update(int id, bool act)
        {
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"update curricula set activo=" + i + " where id_curricula = " + id;
            c.nonQuery(sql);
        }

    }
}