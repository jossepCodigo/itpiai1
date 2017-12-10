using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Persona
    {
        public Persona() {

        }
   
        public static List<Object> obtenerPerId(int id)
        {
            Data c = new Data();
            string consult = "select * from persona where persona.id_persona =" + id;
            SqlDataReader res = c.consulta(consult);
            List<Object> pers = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                pers.Add(res.GetInt32(0));
                pers.Add(res.GetInt32(1));
                pers.Add(res.GetInt32(2));
                pers.Add(res.GetString(3));
                pers.Add(res.GetString(4));
                pers.Add(res.GetString(5));
                byte r;
                bool rr = res.GetBoolean(6);
                if (rr == true) { r = 1; }
                else { r = 0; }
                pers.Add(r);
                pers.Add(res.GetString(7));
                pers.Add(res.GetString(8));
                pers.Add(res.GetString(9));
                pers.Add(res.GetDateTime(10));
            }
            res.Close();
            return pers;
        }

        public static List<Object> obtenerPerCi(int ci)
        {
            Data c = new Data();
            string consult = "select * from persona where persona.ci =" + ci;
            SqlDataReader res = c.consulta(consult);
            List<Object> pers = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                pers.Add(res.GetInt32(0));
                pers.Add(res.GetInt32(1));
                pers.Add(res.GetInt32(2));
                pers.Add(res.GetString(3));
                pers.Add(res.GetString(4));
                pers.Add(res.GetString(5));
                byte r;
                bool rr = res.GetBoolean(6);
                if (rr == true) { r = 1; }
                else { r = 0; }
                pers.Add(r);
                pers.Add(res.GetString(7));
                pers.Add(res.GetString(8));
                pers.Add(res.GetString(9));
                pers.Add(res.GetDateTime(10));
            }
            res.Close();
            return pers;
        }
         
        public static void insertar(int idUs,int ci,string nom,string app,string apm,
            byte sexo,string dom,string corr,string nacion,DateTime nacm) {
            string naciminieto = nacm.ToString(@"MM/dd/yy");
            
            Data c = new Data();
            string sql = @"insert into persona values("+idUs+","+ci+",'"+nom+"','"+app
                +"','"+apm+"',"+sexo+",'"+dom+"','"+corr+"','"+nacion+"','"+naciminieto+"')";
            c.nonQuery(sql);
        }

        public static void update(int id,int ci, string nom, string app, string apm,
            byte sexo, string dom, string corr, string nacion, DateTime nacm)
        {
            string naciminieto = nacm.ToString(@"MM/dd/yy");
            Data c = new Data();
            string sql = @"update persona set ci="+ci+", nombre='"+nom+"', apellido_p='"+app+
                "', apellido_m='"+apm+"', sexo="+sexo+", domicilio='"+dom+"', correo='"+corr+
                "', nacionalidad='"+nacion+"', nacimiento='"+naciminieto+"' where id_persona ="+id;
            c.nonQuery(sql);
        }
    }
}