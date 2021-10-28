using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    [SerializeField]
    private NetworkManager networkManager;

    [SerializeField]
    GameObject[] characters;

    [SerializeField]
    int selectedCharacter;


    [SerializeField]
    GameObject[] characterPrefabs;

    //static public string selectedCharacterKey = "selectedCharacter";

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);


    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;

        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }

        characters[selectedCharacter].SetActive(true);

    }

   
    public void PlayGame()
    {
        //PlayerPrefs.SetInt(selectedCharacterKey, selectedCharacter);

        if (MenuScript.isHost)
        {
            LoadCharacter();
            networkManager.StartHost();

        }
        else if (MenuScript.isClient)
        {
            LoadCharacter();
            networkManager.StartClient();

        }
    }



    void LoadCharacter()
    {
        networkManager.playerPrefab = characterPrefabs[selectedCharacter];
        GameObject characterClone = Instantiate(networkManager.playerPrefab);
    }


}
