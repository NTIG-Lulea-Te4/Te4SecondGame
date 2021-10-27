using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;

public class GetScores : MonoBehaviour
{
    string dbLocation;
    Text leaderboard;
    object sqliteSimple;
    // Start is called before the first frame update
    void Start()
    {
        sqliteSimple = GetComponent<SQLiteSimple>();
        leaderboard.text = GetScoresFromDb();
        
    }

    // Update is called once per frame
    
    void Update()
    {
        

    }

  

    public string GetScoresFromDb()
    {
        dbLocation = "URI=file:Scoreboard.db";
        string scores;
        using (SqliteConnection connection = new SqliteConnection(dbLocation))
        {
            connection.Open();

            using (SqliteCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM scores;";
                
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
