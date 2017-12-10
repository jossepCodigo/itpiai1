using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Telefono
    {
        public static void insertar(int idPers, int numero, string tipo)
        {
            Data c = new Data();
            string sql = @"insert into telefono values("+idPers+","+numero+",'"+tipo+"')";
            c.nonQuery(sql);
        }

        public static List<Object> obtenerPorN(int num)
        {
            Data c = new Data();
            string consult = "select * from telefono where telefono.numero = "+num;
            SqlDataReader res = c.consulta(consult);
            List<Object> pers = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                pers.Add(res.GetInt32(0));
                pers.Add(res.GetInt32(1));
                pers.Add(res.GetInt32(2));
                pers.Add(res.GetString(3));
            }
            res.Close();
            return pers;
        }

        public static List<Object> obtenerTelefonoPersona(int id) {
            Data c = new Data();
            string consult = "select * from telefono where id_persona = "+ id;
            SqlDataReader res = c.consulta(consult);
            List<Object> telefs = new List<object>();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    List<Object> tl = new List<object>();
                    tl.Add(res.GetInt32(0));
                    tl.Add(res.GetInt32(1));
                    tl.Add(res.GetInt32(2));
                    tl.Add(res.GetString(3));
                    telefs.Add(tl);
                }
            }
            res.Close();
            return telefs;
        }

        public static void eliminar(int id) {
            Data c = new Data();
            string consult = "delete from telefono where telefono.id_telefono = " + id;
            SqlDataReader res = c.consulta(consult);
            res.Close();
        }
    }
}