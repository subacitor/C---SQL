using QuanLyBanHang.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BusinessLayer
{
    public class BLL_HeThong
    {
        MyDatabase _db;
        public BLL_HeThong() {

        }
        public BLL_HeThong(string path)
        {
            _db = new MyDatabase(path);
        }

        public bool CheckConnect(ref string err)
        {
            return _db.CheckConnect(ref err);
        }
        public SqlConnectionStringBuilder ReadConnectionString(string path)
        {
            SqlConnectionStringBuilder rs = null;
            ConnectionStringManager.Instace.ReadConnectionString(path);
            rs = ConnectionStringManager.Instace._SqlConnectionStringBuilder;

            return rs;
        }
    }
}
