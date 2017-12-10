using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAPADATOS
{
    public class Data
    {
        SqlConnection cn;
        SqlCommand cmd;
        
        public Data() {
            try
            {
                //Data Source = JOSSEP2\SQLEXPRESS; Initial Catalog = instituto; Integrated Security = True
                cn = new SqlConnection(@"Data Source=LAPTOR_JHASMANY\SQLEXPRESS01;Initial Catalog=instituto;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo conectar con la base de datos" + ex.ToString());
            }
        }

        public SqlDataReader consulta(string consul) {
            SqlDataReader dr;
            try
            {
                cmd = new SqlCommand(consul, cn);
                dr = cmd.ExecuteReader();
                return dr;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error en Consulta" + ex.ToString());
            }
            return null;
        }

        public void nonQuery(string sql) {
            try
            {
                cmd = new SqlCommand(sql, cn);
                //cmd.CommandType = CommandType.Text;
                int rowsAffected = cmd.ExecuteNonQuery();
                this.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en Insert" + ex.ToString());
            }
        }
    }
}