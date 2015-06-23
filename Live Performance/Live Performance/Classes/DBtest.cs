using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;
namespace Live_Performance.Classes
{
    using System.Windows.Forms;

    using Oracle.DataAccess.Client;

    class DBtest : Database
    {
        public bool ConnectionTest(int id)
        {
            var resultaat = false;
            var sql = "SELECT....";
            try
            {
                this.Connect();
                var cmd = new OracleCommand(sql, this.Connection);
                cmd.Parameters.Add(new OracleParameter("id", id));
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //id = Convert.ToInt32(reader["ID"]);
                    }

                    resultaat = true;
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                this.DisConnect();
            }
            return resultaat;
        }
    }
}
