using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteka_KP.SQL
{
    internal class SqlConnector
    {
        MySqlConnection mConn;
        MySqlCommand command;
        public SqlConnector()
        {
            string server = "127.0.0.1";// nazwa serwera lub adres IP
            string database = "Biblioteka_KP";//nazwa bazy danych
            string uid = "root";//nazwa użytkownika
            string password = "secret";//hasło
            string ConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            mConn = new MySqlConnection(ConnectionString);
        }

        public MySqlDataReader sendQuery(string query)
        {

            if (mConn.State != System.Data.ConnectionState.Open) mConn.Open();

            command = new MySqlCommand(query, mConn);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;

        }

        public MySqlCommand getSqlCommand() {
            return command;
        }
        

        
    }
}
