using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    using Oracle.DataAccess.Client;

    class DBBoot : Database
    {
        public List<Boot> SelectAllBoots()
        {
            List<Boot> BootList = null;
            string sql;
            sql = "SELECT * FROM G_BOOT WHERE MISSIE_ID IS NULL";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.Connection);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.HasRows)
                    {
                        BootList.Add(
                            new Boot(
                                Convert.ToInt32(reader["ID"]),
                                new Location(Convert.ToInt32(reader["LocatieX"]), Convert.ToInt32(reader["LocatieX"])),
                                Convert.ToInt32(reader["Max_Persoon"]),
                                Convert.ToInt32(reader["Max_Snelheid"]),
                                Convert.ToString(reader["naam"]),
                                Convert.ToString(reader["GTYPE"])));
                    }
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.Connection.Close();
            }

            return BootList;
        }
    }
}
