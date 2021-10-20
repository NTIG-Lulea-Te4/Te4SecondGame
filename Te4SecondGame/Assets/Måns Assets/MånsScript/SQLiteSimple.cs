using System.Collections;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using UnityEngine;

public class SQLiteSimple : MonoBehaviour
{
    private string databaseName;
    // Start is called before the first frame update
    void Start()
    {
        databaseName = "URI=file:Scoreboard.db";
        CreateDB();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDB() 
    { 
    
        
        using (SqliteConnection connection = new SqliteConnection(databaseName)) 
        {
            connection.Open();

            using (SqliteCommand command = connection.CreateCommand()) 
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS scores (name STRING, score INT);";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        
    
    }

    public void AddScore(string name, int score) 
    {

        using (SqliteConnection connection = new SqliteConnection(databaseName))
        {
            connection.Open();

            using (SqliteCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO scores (name, score) VALUES ('" + name + "','" + score + "');";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }



    }

    public void DisplayScore()
    {


        using (SqliteConnection connection = new SqliteConnection(databaseName))
        {
            connection.Open();

            using (SqliteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM score;";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }


    }

}
