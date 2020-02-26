using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysAdm
{
    public abstract class ClsCrud
    {
        public ClsConnection connection;
        public DataSet Ds;
        public DataTable Dt;

        abstract public string Insert();
        abstract public string Update();
        abstract public string Query();
        abstract public string Grid();
        abstract public string Delete();

        public void InsertLog()
        {

        }
    }
}
