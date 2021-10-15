using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JoinLobbyMenu : MonoBehaviour
{

    [SerializeField]
    private NetworkManagerLobby networkManager;

    [Header("UI")]

    [SerializeField] 
    private GameObject landingPagePanel;

    [SerializeField]
    private TMP_InputField ipAdressInputField;

    [SerializeField]
    private Button joinButton;



    private void OnEnable()
    {
        NetworkManagerLobby.OnClientConnected += HandleClientConnected;
        NetworkManagerLobby.OnClientConnected += HandleClientDisconnected;
    }

    private void OnDisable()
    {
        NetworkManagerLobby.OnClientConnected -= HandleClientConnected;
        NetworkManagerLobby.OnClientConnected -= HandleClientDisconnected;
    }

    public void JoinLobby()
    {
        string ipAdress = ipAdressInputField.text;

        networkManager.networkAddress = ipAdress;
        networkManager.StartClient();

        joinButton.interactable = false;

    }

    private void HandleClientConnected()
    {
        joinButton.interactable = true;

        gameObject.SetActive(false);
        landingPagePanel.SetActive(false);

    }

    private void HandleClientDisconnected()
    {
        joinButton.interactable = true;

    }

}
