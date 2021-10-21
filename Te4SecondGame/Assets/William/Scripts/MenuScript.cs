using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    #region SerializeField
    [SerializeField]
    private NetworkManager networkManager;

    [SerializeField]
    private GameObject landingPagePanel;

    [SerializeField]
    private GameObject IpInputFieldPanel;

    [SerializeField]
    private InputField inputFieldForIpAdress;

    #endregion

    private void Start()
    {
        //inGameMenuCanvas.SetActive(false);
    }

    private void Update()
    {

    }

    public void OnHostOnlyButtonClick()
    {
        networkManager.StartServer();

        //inGameMenuCanvas.SetActive(true);
    }

    public void OnHostAndPlayButtonClick()
    {
        networkManager.StartHost();

       // inGameMenuCanvas.SetActive(true);
        Debug.Log("Hosting game...");
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
        networkManager.StartClient();

       // inGameMenuCanvas.SetActive(true);
    }

    static public void OnExitClick()
    {
        Application.Quit();
        Debug.Log("Quitting game...");
    }

    
}
