using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLNHANVIEN.DAO
{
    public class ConnectOracle
    {
        public ConnectOracle() { }
        public OracleConnection connectOracle(string user, string psw) {
            OracleConnection conn = null;
            string loginQuery = @"DATA SOURCE=localhost:1521/qlnvpdb;USER ID=" + user + ";PASSWORD=" + psw;
            conn = new OracleConnection(loginQuery);
            return conn;
        }
    }
}
