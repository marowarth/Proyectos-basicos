using Dapper;
using System.Data.SqlClient;

//string connectionString = "Server=TuServidor;Database=TuBaseDeDatos;User Id=TUsuario;Password=TContraseña;";
string connectionString = "Server=ERAOL\\SQLEXPRESS;Database=sql_curso_YT;User Id=eraol;Password=evil181288;";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    string query = "SELECT * FROM ejemploCollate;";
    var results = connection.Query(query);

    foreach (var row in results)
    {
        Console.WriteLine(row.name + " - " + row.value);
    }
}