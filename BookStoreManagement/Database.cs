using MySql.Data.MySqlClient;

public class Database
{
    private MySqlConnection connection;

    public Database()
    {
        string connectionString = "server=localhost;database=bookstore;uid=root;pwd=yourpassword;";
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection GetConnection()
    {
        return connection;
    }
}
