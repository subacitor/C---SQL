using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DataLayer
{
    public class MyDatabase
    {
        //Ado object
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public MyDatabase(string path)
        {
            ConnectionStringManager.Instace.ReadConnectionString(path);
            conn = new SqlConnection(ConnectionStringManager.Instace._SqlConnectionStringBuilder.ConnectionString);
        }

        public bool CheckConnect(ref string err)
        {
            try
            {   
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                
                err = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public int MyExcuteNonQuery(ref string err, string querry, CommandType commandType, params SqlParameter[] param)
        {
            int result = 0;
            try
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                cmd = new SqlCommand(querry, conn);
                cmd.CommandType = commandType;
                cmd.CommandTimeout = 600;
                if (param != null)
                {
                    foreach(SqlParameter par in param)
                    {
                        cmd.Parameters.Add(par);
                    }
                }
                result = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
