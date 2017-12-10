using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPADATOS
{
    public class Especialidad
    {
        public static List<Object> obtener(int id){
            Data c = new Data();
            string consult = "select * from especialidad where estado=1 and  id_especialidad =" + id;
            SqlDataReader res = c.consulta(consult);
            List<Object> esp = new List<object>();
            if (res.HasRows){
                    res.Read();
                    esp.Add(res.GetInt32(0));
                    esp.Add(res.GetString(1));
            }
            res.Close();
            return esp;
        }

        public static List<Object> obtener(string nombre){
            Data c = new Data();
            string consult = "select * from especialidad where estado=1 and nombre ='" + nombre+"'";
            SqlDataReader res = c.consulta(consult);
            List<Object> esp = new List<object>();
            if (res.HasRows){
                res.Read();
                esp.Add(res.GetInt32(0));
                esp.Add(res.GetString(1));
            }
            res.Close();
            return esp;
        }

        public static List<Object> all(int id) {
            Data c = new Data();
            string consult = "select * from especialidad where estado=1 and id_especialidad not in (select esp_doc.id_especialidad from esp_doc where esp_doc.id_docente=" + id+")";
            SqlDataReader res = c.consulta(consult);
            List<Object> esps = new List<object>();
            if (res.HasRows){
                while (res.Read()){
                    List<Object> esp = new List<object>();
                    esp.Add(res.GetInt32(0));
                    esp.Add(res.GetString(1));
                    esps.Add(esp);
                }
            }
            res.Close();
            return esps;
        }

        public static List<Object> especialidades_Docente(int idDocente) {
            Data c = new Data();
            string consult = "select especialidad.id_especialidad,especialidad.nombre from docente,esp_doc,especialidad where docente.id_docente = esp_doc.id_docente and especialidad.id_especialidad = esp_doc.id_especialidad and docente.id_docente=" + idDocente;
            SqlDataReader res = c.consulta(consult);
            List<Object> esps = new List<object>();
            if (res.HasRows){
                while (res.Read()){
                    List<object> esp = new List<object>();
                    esp.Add(res.GetInt32(0));
                    esp.Add(res.GetString(1));
                    esps.Add(esp);
                }
            }
            res.Close();
            return esps;
        }

        public static void insertar(string nombre){
            Data c = new Data();
            string sql = @"insert into especialidad values('"+nombre+"',1)";
            c.nonQuery(sql);
        }

        public static void insertarED(int idDoc,int idEsp){
            Data c = new Data();
            string sql = @"insert into esp_doc values("+idDoc+","+idEsp+")";
            c.nonQuery(sql);
        }

        public static void eliminar(string nom){
            Data c = new Data();
            string consult = @"update especialidad set estado = 0 where nombre = '"+nom+"'";
            SqlDataReader res = c.consulta(consult);
            res.Close();
        }

        public static void eliminarED(int idDoc,int idEsp) {
            Data c = new Data();
            string consult = @"delete from esp_doc where id_docente = "+idDoc+
                " and id_especialidad = "+idEsp;
            SqlDataReader res = c.consulta(consult);
            res.Close();
        }
    }
}