using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AgendaBeta
{
    public class MySql
    {
        private string database;
        private string server;
        private string password;
        private string user;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;

        public string Database
        {
            get { return database; }
        }
        public string Server
        {
            get { return server; }
        }
        public string User
        {
            get { return user; }
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        
        public MySql(string server,string  database,string user, string password)
        {
            this.database = database;
            this.user = user;
            this.password = password;
            this.server = server;
            string connectionString;
            connectionString = "SERVER=" + server + ";DATABASE=" + database +
                ";UID=" + user + ";PASSWORD=" + password + ";";
            this.connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException exception)
            {
                switch (exception.Number)
                {
                    case 0:
                        //No se puede conectar al servidor. Contacte al administrador
                        break;
                    case 1:
                        //Contraseña invalida, intente otra vez
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException exception)
            {
                //exception.Message
                return false;
            }
        }
        public void Insert(string query, MySqlParameter[] data)
        {
            if (this.OpenConnection())
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(data);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Update(string query, MySqlParameter[] data)
        {
            if (this.OpenConnection())
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(data);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete(string query, MySqlParameter[] data)
        {
            if (this.OpenConnection())
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(data);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public List<string>[] Select(string query, MySqlParameter[] data)
        {
            List<string>[] columns = new List<string>[data.Length + 1];
            for (int c = 0; c < columns.Length; c++)
                columns[c] = new List<string>();

            if (this.OpenConnection())
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(data);
                dataReader = command.ExecuteReader();
                for (int i = 0; (i < columns.Length) && dataReader.Read(); i++)
                {
                    for (int j = 0; dataReader.HasRows; j++)
                    {
                        columns[i].Add(dataReader[j] + "");
                    }
                }
                dataReader.Close();
                this.CloseConnection();
                return columns;
            }
            else return null;
        }
        public int Count(string query, MySqlParameter[] data)
        {
            int count = -1;
            if (this.OpenConnection())
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(data);
                count = int.Parse(command.ExecuteScalar() + "");
                this.CloseConnection();
                return count;
            }
            else return 0;
        }
        public double Average(string query, MySqlParameter[] data)
        {
            double avg = 0d;
            if (this.OpenConnection())
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(data);
                avg = double.Parse(command.ExecuteScalar() + "");
                this.CloseConnection();
                return avg;
            }
            else return avg;
        }
    }
}