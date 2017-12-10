using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Carrera
    {
        public static List<Object> obtenerCarrId(int idCarr){
            Data c = new Data();
            string consult = "select * from carrera where activo=1 and carrera.id_carrera =" + idCarr;
            SqlDataReader res = c.consulta(consult);
            List<Object> carr = new List<Object>();
            if (res.HasRows){
                res.Read();
                carr.Add(res.GetInt32(0));
                carr.Add(res.GetString(1));
                carr.Add(res.GetString(2));
                carr.Add(res.GetInt32(3));
                carr.Add(res.GetBoolean(4));
            }
            res.Close();
            return carr;
        }
        public static List<Object> obtenerCarrNom(string nomb)
        {
            Data c = new Data();
            string consult = @"select * from carrera where activo=1 and carrera.nombre = '" + nomb+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> carr = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                carr.Add(res.GetInt32(0));
                carr.Add(res.GetString(1));
                carr.Add(res.GetString(2));
                carr.Add(res.GetInt32(3));
                carr.Add(res.GetBoolean(4));
            }
            res.Close();
            return carr;
        }

        public static List<Object> all(){
            Data c = new Data();
            string consult = "select * from carrera where activo=1";
            SqlDataReader res = c.consulta(consult);
            List<Object> carrs = new List<object>();
            if (res.HasRows){
                while (res.Read()){
                    List<Object> car = new List<object>();
                    car.Add(res.GetInt32(0));
                    car.Add(res.GetString(1));
                    car.Add(res.GetString(2));
                    car.Add(res.GetInt32(3));
                    car.Add(res.GetBoolean(4));
                    carrs.Add(car);
                }
            }
            res.Close();
            return carrs;
        }

        public static void insertar(string nom, string mod, int dur, bool act)
        {
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"insert into carrera values('"+nom+"','"+mod+"',"+dur+","+i+");";
            c.nonQuery(sql);
        }
        public static void update(int id,string nom, string mod, int dur, bool act)
        {
            int i = 0;
            if (act) i = 1;
            Data c = new Data();
            string sql = @"update carrera set nombre='"+nom+"', modalidad = '"+mod+"', duracion="+dur+", activo="+i+" where id_carrera ="+id;
            c.nonQuery(sql);
        }
    }
}