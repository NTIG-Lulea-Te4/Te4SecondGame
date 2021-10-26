using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;

public class GetScores : MonoBehaviour
{
    string dbLocation;
    Text leaderboard;
    SQLiteSimple sqliteSimple;
    // Start is called before the first frame update
    void Start()
    {
        sqliteSimple.AddScore("harry", 500);
        
    }

    // Update is called once per frame
    void DisplayScores() 
    {
        
    
    
    }
    
    void Update()
    {
        
        leaderboard.text = GetScoresFromDb();

    }

  

    public string GetScoresFromDb()
    {
        dbLocation = sqliteSimple.ScoreboardDatabase;
        string scores;
        using (SqliteConnection connection = new SqliteConnection(dbLocation))
        {
            connection.Open();

            using (SqliteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM score;";
                
                using (SqliteDataReader reader = command.ExecuteReader())
                {

                    scores =  "name" + reader["name"] + "score" + reader["score"] + "\n";

                }

            }

            connection.Close();
            return scores;
        }



    }

}
