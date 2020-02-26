using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysAdm
{
    public class ClsConnection
    {
        public SqlConnection connection = new SqlConnection();

        public SqlConnection Connect()
        {
            Disconnect();
            connection.ConnectionString = "Server = IBM-PC\\SQLEXPRESS; Database = db_Tind4S; Uid = userTind4s; Trusted_Connection=True;";
            //conexao.ConnectionString = "Server = db-tind4s.chwaokuky6hn.sa-east-1.rds.amazonaws.com, 1433; Database = db_Tind4S; Uid = adminTind4S; Pwd = mineirofoda;";
            connection.Open();
            return connection;
        }

        public void Disconnect()
        {
            connection.Close();
        }
    }
}
