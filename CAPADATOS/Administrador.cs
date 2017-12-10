using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Administrador
    {
        public static List<Object> obtenerDocId(int idDoc)
        {
            Data c = new Data();
            string consult = "select * from administrador where administrador.id_admin =" + idDoc;
            SqlDataReader res = c.consulta(consult);
            List<Object> doc = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                doc.Add(res.GetInt32(0));
                doc.Add(res.GetInt32(1));
                doc.Add(res.GetString(2));
                doc.Add(res.GetString(3));
            }
            res.Close();
            return doc;
        }

        public static List<Object> obtenerDocCi(int ci)
        {
            Data c = new Data();
            string consult = "select administrador.id_admin,administrador.id_persona,administrador.cargo,administrador.imagen from administrador,persona where administrador.id_persona = persona.id_persona and persona.ci = " + ci;
            SqlDataReader res = c.consulta(consult);
            List<Object> doc = new List<Object>();
            if (res.HasRows)
            {
                res.Read();
                doc.Add(res.GetInt32(0));
                doc.Add(res.GetInt32(1));
                doc.Add(res.GetString(2));
                doc.Add(res.GetString(3));
            }
            res.Close();
            return doc;
        }

        public static void insertar(int idPer, string carg, string img)
        {
            Data c = new Data();
            string sql = @"insert into administrador values("+idPer+",'"+carg+"','"+img+"')";
            c.nonQuery(sql);
        }
        public static void update(int id, string carg, string img)
        {
            Data c = new Data();
            string sql = @"update administrador set cargo='"+carg+"', imagen = '"+img+"' where id_admin ="+id;
            c.nonQuery(sql);
        }
    }
}
