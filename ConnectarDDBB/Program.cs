using System.Data.SqlClient;
//conexion con user y pass
//string connectionString = "Server=TuServidor;Database=TuBaseDeDatos;User Id=TUsuario;Password=TContraseña;";
//conexion con windows
//string connectionString = "Server=TuServidor;Database=TuBaseDeDatos;Integrated Security=True;";
string connectionString = "Server=ERAOL\\SQLEXPRESS;Database=sql_curso_YT;Integrated Security=True;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string query = "SELECT * FROM ejemploCollate;";
    using (SqlCommand command = new SqlCommand(query, connection))
    using (SqlDataReader reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine(reader["name"] + " - " + reader["value"]);
        }
    }
}