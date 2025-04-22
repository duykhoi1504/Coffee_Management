using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferLayer;

namespace DataLayer
{
    public class LoginDL : DataProvider
    {
        public bool Login(Account a) 
        {
            string sql = "SELECT COUNT(username) FROM Account WHERE username = '" + a.username + "' AND password = '" + a.password + "'";

            try
            {
                return ((int)(MyExecuteScalar(sql, CommandType.Text)) > 0);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
