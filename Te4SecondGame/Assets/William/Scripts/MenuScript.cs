using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    #region SerializeFields/Variables
    [SerializeField]
    private NetworkManager networkManager;

    [SerializeField]
    private GameObject landingPagePanel;

    [SerializeField]
    private GameObject IpInputFieldPanel;

    [SerializeField]
    private InputField inputFieldForIpAdress;

    static public bool isMainMenuActive;

    public static bool isHost;
    public static bool isServer;
    public static bool isClient;

    public Camera mainMenuCamera;
    public Camera characterSelectionCamera;

    #endregion


    private void Start()
    {
        mainMenuCamera.enabled = true;
        characterSelectionCamera.enabled = false;
    }

    private void Awake()
    {
        isMainMenuActive = true;
    }

    public void OnHostOnlyButtonClick()
    {
        networkManager.StartServer();
        isMainMenuActive = false;
    }

    public void OnHostAndPlayButtonClick()
    {
        //networkManager.StartHost();

        mainMenuCamera.enabled = false;
        characterSelectionCamera.enabled = true;

        isHost = true;

        isMainMenuActive = false;
        
    }

    public void OnJoinAsClientClick()
    {
        landingPagePanel.SetActive(false);
        IpInputFieldPanel.SetActive(true);

    }

    public void OnBackButtonClick()
    {
        landingPagePanel.SetActive(true);
        IpInputFieldPanel.SetActive(false);

       
    }

    //Ger nätverks adressen ett nytt värde beroande på vad som skivs in i inputfield
    //Sedan connectar clienten med servern med nätverks adressen
    public void OnJoinServerClick()
    {
        string ipAdress = inputFieldForIpAdress.text;

        networkManager.networkAddress = ipAdress;
        //networkManager.StartClient();

        mainMenuCamera.enabled = false;
        characterSelectionCamera.enabled = true;

        isClient = true;


        isMainMenuActive = false;
    }

    static public void OnExitClick()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }

    
}
