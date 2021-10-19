using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;

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




    public void OnHostButtonClick()
    {
        networkManager.StartHost();

    }

    #region UI Panel on/off

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

    #endregion

    //Ger n�tverks adressen ett nytt v�rde beroande p� vad som skivs in i inputfield
    //Sedan connectar clienten med servern med n�tverks adressen
    public void OnJoinServerClick()
    {
        string ipAdress = inputFieldForIpAdress.text;

        networkManager.networkAddress = ipAdress;
        networkManager.StartClient();


    }

    static public void OnExitClick()
    {
        Application.Quit();
    }

    static public void OnMainMenuClick()
    {

    }

    
}
