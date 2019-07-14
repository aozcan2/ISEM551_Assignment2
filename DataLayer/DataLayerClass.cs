using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataLayerClass{


        public static DataSet GetDatafromDB()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsGetDemographicsReport = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["BookDbContext"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "select * from dbo.books";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetDemographicsReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetDemographicsReport;
        }
    }
}
