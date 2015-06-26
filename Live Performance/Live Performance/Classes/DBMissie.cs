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

        public Missie SelectMissie(int Missieid)
        {
            Missie Missie = new Missie();
            string sql;
            bool actief;
            bool goedgekeurd;
            string datumterug;
            string datumvertrek;
            int id;
            string naam;
            Location location = null;
            sql = "SELECT * FROM G_MISSIE WHERE ID = :id";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.Connection);
                cmd.Parameters.Add(new OracleParameter("id", Missieid));
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
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
                        Missie = new Missie(id, naam, actief, datumvertrek, datumterug, goedgekeurd, location);
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

            return Missie;
        }


        public bool AddMissie(Missie missie)
        {
            bool result = false;
            string sql;

            sql = "INSERT INTO G_MISSIE (NAAM,LOCATIEX, LOCATIEY, DATUMVERTREK, DATUMTERUG, ACTIEF, TYPE, GOEDGEKEURD) VALUES (:naam, :x, :y, :datumvertrek, :datumterug, :actief, :typemissie, :goedgekeurd)";
            try
            {
                int acti = 0;
                int goed = 0;
                if (missie.Actief)
                {
                    acti = 1;
                }
                if (missie.Goedgekeurd)
                {
                    goed = 1;
                }
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.Connection);
                cmd.Parameters.Add(new OracleParameter("naam", missie.Naam));
                cmd.Parameters.Add(new OracleParameter("x", missie.Location.X));
                cmd.Parameters.Add(new OracleParameter("y", missie.Location.Y));
                cmd.Parameters.Add(new OracleParameter("datumvertrek", missie.DatumVertrek));
                cmd.Parameters.Add(new OracleParameter("datumterug", missie.DatumTerug));
                cmd.Parameters.Add(new OracleParameter("actief", acti));
                cmd.Parameters.Add(new OracleParameter("goedgekeurd", goed));
                cmd.Parameters.Add(new OracleParameter("typemissie", missie.Type));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.Connection.Close();
            }

            return result;
        }

    }
}
