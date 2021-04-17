using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace official_pro
{
    

    class ConnectDB
    {
        static string ds = "Data Source = DESKTOP-ORFSP8L; Initial Catalog = demoDb; Integrated Security = True;";
        SqlConnection conn = new SqlConnection(ds);
        public bool Insert(Shitesit sh)
        {
            bool isSuccess = false;
            try
            {

                string sql = "Insert Into Shitesit ( emriShitesit, shumaShitesit, dataDheKoha, Bleresi) VALUES ( @emriShitesit, @shumaShitesit, @dataDheKoha, @Bleresi )";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emriShitesit", sh.emriShitesit);
                cmd.Parameters.AddWithValue("@shumaShitesit", sh.shumaShitesit);
                cmd.Parameters.AddWithValue("@dataDheKoha", sh.dataDheKoha);
                cmd.Parameters.AddWithValue("@Bleresi", sh.Blersi);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
