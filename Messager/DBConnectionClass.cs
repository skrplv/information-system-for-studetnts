using System.Data.SqlClient;

namespace ConnectionDB
{
    //Класс подключения к БД
    class DBConnectionClass
    {
        // Строка подключения
        readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\is-for-students\db-is-for-student.mdf;Integrated Security=True;Connect Timeout=30");
        // Метод открытия соединения
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }            
        }
        // Метод закрытия соединения
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // Метод получения соединения
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }

}
