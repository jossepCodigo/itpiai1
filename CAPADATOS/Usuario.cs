using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CAPADATOS;

namespace CAPADATOS
{
    public class Usuario
    {

        public Usuario()
        {
        }

        public static List<Object> obtenerUs(int id) {
            Data c = new Data();
            string consult = "select * from usuario where usuario.id_usuario =" + id;
            SqlDataReader res = c.consulta(consult);
            List<Object> user = new List<object>();
            if (res.HasRows)
            {
                res.Read();
                user.Add(res.GetInt32(0));
                user.Add(res.GetString(1));
                user.Add(res.GetString(2));
                user.Add(res.GetString(3));
                user.Add(res.GetBoolean(4));
                user.Add(res.GetInt32(5));
            }
            res.Close();
            return user;
        }

        public static bool existe(string us) {
            Data c = new Data();
            string consult = "select * from usuario where username='" + us + "'";
            SqlDataReader res = c.consulta(consult);
            List<Object> user = new List<object>();
            if (res.HasRows)
            {
                return true;
            }
            res.Close();
            return false;
        }

        public static List<Object> obtenerUs(string us)
        {
            Data c = new Data();
            string consult = "select * from usuario where username='" + us + "'";
            SqlDataReader res = c.consulta(consult);
            List<Object> user = new List<object>();
            if (res.HasRows)
            {
                res.Read();
                user.Add(res.GetInt32(0));
                user.Add(res.GetString(1));
                user.Add(res.GetString(2));
                user.Add(res.GetString(3));
                user.Add(res.GetBoolean(4));
                user.Add(res.GetInt32(5));
            }
            res.Close();
            return user;
        }

        public static List<Object> obtenerUs(string us, string pass)
        {
            Data c = new Data();
            string consult = "select * from usuario where username='" + us + "' and passwords ='"+ pass +"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> user = new List<object>();
            if (res.HasRows){
                res.Read();
                user.Add(res.GetInt32(0));
                user.Add(res.GetString(1));
                user.Add(res.GetString(2));
                user.Add(res.GetString(3));
                user.Add(res.GetBoolean(4));
                user.Add(res.GetInt32(5));
            }
            res.Close();
            return user;
        }
        
        public static void insertar(string us, string pass, string tipo, bool activo,
            int intento)
        {
            int i;
            if (activo) i = 1;
            else i = 0; 
            Data c = new Data();
            string sql = @"insert into usuario values('"+us+"','"+pass+"','"+tipo+"',"+
                i+","+intento+")";
            c.nonQuery(sql);
        }

        public static void update(int id, string us, string pass, string tipo, bool activo,
            int intentos)
        {
            int i;
            if (activo) i = 1;
            else i = 0;
            Data c = new Data();
            string sql = @"update usuario set username = '"+us+"', passwords = '"+pass+
                "', tipo_usuario = '"+tipo+"', activo = "+i+", intentos = "+intentos+
                " where id_usuario =" + id;
            c.nonQuery(sql);
        }
    }
}