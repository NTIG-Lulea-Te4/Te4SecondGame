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

    bool isEscapedPressed;

    public void OnHostButtonClick()
    {

        networkManager.StartHost();

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

    //public void SetIpAdress(string ipAdress)
    //{
    //    networkManager.networkAddress = ipAdress;
    //}

    public void OnJoinServerClick()
    {
        string ipAdress = inputFieldForIpAdress.text;

        networkManager.networkAddress = ipAdress;
        networkManager.StartClient();


    }

    public void OnExitClick()
    {
        Application.Quit();
    }

    public void OnMainMenuClick()
    {

    }

    void Start()
    {
        isEscapedPressed = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isEscapedPressed = !isEscapedPressed;
        }
        if (isEscapedPressed)
        {


        }


    }
}
