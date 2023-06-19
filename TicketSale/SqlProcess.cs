using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSale
{
    public class SqlProcess
    {

        private string connectionString = "Server=.;Database=TicketSale;User Id=Cuni;Password=123456;";
        SqlConnection connection = null;
        SqlCommand command = null;        
        private Dictionary<string, Tuple<string, string>> airports = new Dictionary<string, Tuple<string, string>>();

        public bool SqlConnect(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace:" + ex.StackTrace, "Sql Bağlantı Hatası");
                return false;
            }
        }

        public Dictionary<string, Tuple<string, string>> SqlRead(string query)
        {
            try
            {
                SqlDataReader reader = null;
                if (!SqlConnect(connectionString))
                    return null;
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                    airports.Add(reader.GetString(1), Tuple.Create(reader.GetString(2), reader.GetString(3)));
                command.Dispose();
                command = null;
                reader.Close();
                reader = null;
                return airports;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "SqlRead Hatası");
                return null;
            }
        }

    }
}
