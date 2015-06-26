using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    using Oracle.DataAccess.Client;

    class DBMissie : Database
    {
        public void AddMissie(Missie missie)
        {
            throw new NotImplementedException();
        }

        public List<Missie> SelectAllMissies()
        {
            List<Missie> MissieList = new List<Missie>();
            string sql;
            bool actief;
            bool goedgekeurd;
            string datumterug;
            string datumvertrek;
            int id;
            string naam;
            Location location = null;
            sql = "SELECT * FROM G_MISSIE";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.Connection);
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        actief = false;
                        goedgekeurd = false;
                        datumterug = "";
                        if (Convert.ToInt32(reader["actief"]) == 1)
                        {
                             actief = true;
                        }
                        if (Convert.ToInt32(reader["goedgekeurd"]) == 1)
                        {
                            goedgekeurd = true;
                        }

                        if (reader["DATUMTERUG"] != null)
                        {
                            datumterug = Convert.ToString(reader["DATUMTERUG"]);
                        }

                        id = Convert.ToInt32(reader["ID"]);
                        naam = Convert.ToString(reader["NAAM"]);
                        datumvertrek = Convert.ToString(reader["DATUMVERTREK"]);
                        location = new Location(Convert.ToInt32(reader["LOCATIEX"]), Convert.ToInt32(reader["LOCATIEY"]));
                        MissieList.Add(new Missie(id, naam, actief, datumvertrek, datumterug, goedgekeurd, location));
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

            return MissieList;
        }
    }
}
