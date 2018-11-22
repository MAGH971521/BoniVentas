using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBConnections
{
    class MSSQL
    {
        private string database;
        private string server;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public string Database
        {
            get { return database; }
            set { database = value; }
        }
        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        public MSSQL() { }

        public MSSQL(string server, string database)
        {
            this.server = server;
            this.database = database;
            string connectionString = "server=" + server + "\\SQLEXPRESS; database=" + 
                database + ";integrated security=true";
            this.connection = new SqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException exception)
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
            catch (SqlException exception)
            {
                //exception.Message
                return false;
            }
        }
        public void ExecuteAction(string query, SqlParameter[] data)
        {
            if (this.OpenConnection())
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(data);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public List<string>[] Select(string query, SqlParameter[] data)
        {
            List<string>[] columns = new List<string>[data.Length + 1];
            for (int c = 0; c < columns.Length; c++)
                columns[c] = new List<string>();

            if (this.OpenConnection())
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(data);
                dataReader = command.ExecuteReader();
                for (int i = 0; (i < columns.Length) && dataReader.Read(); i++)
                    for (int j = 0; dataReader.HasRows; j++)
                        columns[i].Add(dataReader[j] + "");
                dataReader.Close();
                this.CloseConnection();
                return columns;
            }
            else
            {
                return null;
            }
        }
        public int Count(string query, SqlParameter[] data)
        {
            if (this.OpenConnection())
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(data);
                this.CloseConnection();
                return int.Parse(command.ExecuteScalar() + "");
            }
            else return 0;
        }
        public double Average(string query, SqlParameter[] data)
        {
            if (this.CloseConnection())
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddRange(data);
                this.CloseConnection();
                return double.Parse(command.ExecuteScalar() + "");
            }
            else return 0;
        }
    }
}
