using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Docente
    {
        public static List<Object> obtenerDocId(int idDoc)
        {
            Data c = new Data();
            string consult = "select * from docente where docente.id_docente =" + idDoc;
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

        public static List<Object> obtenerDocCi(int ci)
        {
            Data c = new Data();
            string consult = "select docente.id_docente,docente.id_persona,docente.fecha_ingreso,docente.imagen from docente,persona where docente.id_persona = persona.id_persona and persona.ci =" + ci;
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

        public static void insertar(int idPer, DateTime fechaIng, string img)
        {
            string fechIngreso = fechaIng.ToString(@"MM/dd/yy");
            Data c = new Data();
            string sql = @"insert into docente values("+idPer+",'"+fechIngreso+"','"+img+"')";
            c.nonQuery(sql);
        }
        public static void update(int id, DateTime fechaIng, string img)
        {
            string fechIngreso = fechaIng.ToString(@"MM/dd/yy");
            Data c = new Data();
            string sql = @"update docente set fecha_ingreso='"+fechIngreso+"', imagen = '"+img+
                "' where id_docente = " + id;
            c.nonQuery(sql);
        }
    }
}