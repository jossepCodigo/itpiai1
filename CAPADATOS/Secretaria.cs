using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Secretaria
    {
        public static List<Object> obtenerSecId(int idSec)
        {
            Data c = new Data();
            string consult = "select * from secretaria where secretaria.id_secretaria=" + idSec;
            SqlDataReader res = c.consulta(consult);
            List<Object> doc = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                doc.Add(res.GetInt32(0));
                doc.Add(res.GetInt32(1));
                doc.Add(res.GetDateTime(2));
                doc.Add(res.GetString(3));
            }
            res.Close();
            return doc;
        }

        public static List<Object> obtenerSecCi(int ci){
            Data c = new Data();
            string consult = "select secretaria.id_secretaria,secretaria.id_persona,secretaria.fecha_ingreso,imagen from secretaria,persona where secretaria.id_persona = persona.id_persona and persona.ci = " + ci;
            SqlDataReader res = c.consulta(consult);
            List<Object> doc = new List<Object>();
            if (res.HasRows){
                res.Read();
                doc.Add(res.GetInt32(0));
                doc.Add(res.GetInt32(1));
                doc.Add(res.GetDateTime(2));
                doc.Add(res.GetString(3));
            }
            res.Close();
            return doc;
        }

        public static void insertar(int idPer, DateTime fechaIng, string img){
            string fechIngreso = fechaIng.ToString(@"MM/dd/yy");
            Data c = new Data();
            string sql = @"insert into secretaria values(" + idPer + ",'" + fechIngreso + "','" + img + "')";
            c.nonQuery(sql);
        }

        public static void update(int id, DateTime fechaIng, string img){
            string fechIngreso = fechaIng.ToString(@"MM/dd/yy");
            Data c = new Data();
            string sql = @"update secretaria set fecha_ingreso='" + fechIngreso + "', imagen = '" + img +
                "' where id_docente = " + id;
            c.nonQuery(sql);
        }
    }
}