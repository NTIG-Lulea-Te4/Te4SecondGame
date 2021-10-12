using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NetworkScript : NetworkManager
{

    [SerializeField]
    Transform firstPlayerSpawn;

    [SerializeField]
    Transform secondPlayerSpawn;

    Transform spawnPosition; //Ger Error men funkar
    

    public override void OnServerAddPlayer(NetworkConnection conn)
    {

        if (numPlayers == 0)
        {
            spawnPosition = firstPlayerSpawn;

        }

        if (numPlayers != 0)
        {
            spawnPosition = secondPlayerSpawn;
        }

        GameObject player = Instantiate(playerPrefab, spawnPosition.position, spawnPosition.rotation);
        NetworkServer.AddPlayerForConnection(conn, player);
    }


}
