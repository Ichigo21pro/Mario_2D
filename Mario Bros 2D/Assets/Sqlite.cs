using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Mono.Data.Sqlite;

public class Sqlite : MonoBehaviour
{
    private string connectionString;

    void Start()
    {
        // Establecer la conexión a la base de datos
        connectionString = "URI=file:" + Application.dataPath + "/nombre_de_tu_base_de_datos.db";
        CreatePlayerTable();  // Asegurarse de que la tabla existe al inicio
    }

    void CreatePlayerTable()
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                // Crear la tabla Jugadores si no existe
                string createTableQuery = "CREATE TABLE IF NOT EXISTS Jugadores (ID INTEGER PRIMARY KEY, Nombre TEXT, Score INTEGER)";
                dbCommand.CommandText = createTableQuery;
                dbCommand.ExecuteNonQuery();
            }

            dbConnection.Close();
        }
    }

    public void InsertPlayerData(string nombre, int score)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                // Insertar datos del jugador
                string insertQuery = "INSERT INTO Jugadores (Nombre, Score) VALUES (@nombre, @score)";
                dbCommand.CommandText = insertQuery;

                // Parámetros
                IDbDataParameter nombreParameter = dbCommand.CreateParameter();
                nombreParameter.ParameterName = "@nombre";
                nombreParameter.Value = nombre;
                dbCommand.Parameters.Add(nombreParameter);

                IDbDataParameter scoreParameter = dbCommand.CreateParameter();
                scoreParameter.ParameterName = "@score";
                scoreParameter.Value = score;
                dbCommand.Parameters.Add(scoreParameter);

                dbCommand.ExecuteNonQuery();
            }

            dbConnection.Close();
        }
    }
}
