using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataLayerClass{


        public static DataSet GetDatafromDB()
        {
            SqlConnection conn;
            string query = null;
            SqlCommand cmd;
            SqlDataReader _dataReader;

            DataTable _dataTable = new DataTable();
            DataSet _dataSet = new DataSet();

            var _connStr = ConfigurationManager.ConnectionStrings["BookDbContext"].ConnectionString;
            conn = new SqlConnection(_connStr);
            query = "select * from dbo.books";

            //Open the connection
            conn.Open();
            cmd = new SqlCommand(query, conn);
            _dataReader = cmd.ExecuteReader();
            _dataTable.Load(_dataReader);
            _dataSet.Tables.Add(_dataTable);
            _dataReader.Close();
            cmd.Dispose();
            conn.Close();

            return _dataSet;
        }
    }
}
