namespace Live_Performance.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Oracle.DataAccess.Client;

    public abstract class Database
    {
        /// <summary>
        /// The connection.
        /// </summary>
        protected OracleConnection Connection = new OracleConnection();

        /// <summary>
        /// The connection string. Change this if you there is a change in the Database
        /// The String is made of the following components
        /// 
        /// Example: "DATA SOURCE=//192.168.15.50:1521/fhictora;PASSWORD=K9k8zLNCO0;USER ID=dbi292421"
        /// The Database location       192.168.15.50:1521
        /// The Password                PASSWORD=K9k8zLNCO0
        /// The User ID                 USER ID=dbi292421
        /// </summary>
        protected string ConnectionString = "DATA SOURCE=//192.168.15.50:1521/fhictora;PASSWORD=K9k8zLNCO0;USER ID=dbi292421";

        /// <summary>
        /// The General Connection method use to connect to the database. If something went wrong it will disconnect automatically
        /// Besure to have a connection to vdi.fhict.nl usign Cisco AnyConnect.
        /// </summary>
        public void Connect()
        {
            try
            {
                this.Connection = new OracleConnection();
                this.Connection.ConnectionString = this.ConnectionString;
                this.Connection.Open();
            }
            catch (Exception exp)
            {
                throw exp;
                this.Connection.Close();
            }
        }

        /// <summary>
        /// The same as the Connect() class exept in reverse.
        /// It will disconnect from the database
        /// </summary>
        public void DisConnect()
        {
            this.Connection.Close();
        }
    }
}
