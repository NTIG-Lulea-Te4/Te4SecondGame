using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : NetworkBehaviour
{

    [SerializeField]
    private GameObject inGameMenuPanel;

    [SerializeField]
    private NetworkManager networkManager;


    bool isMenuActive;

    private void Awake()
    {
        inGameMenuPanel.SetActive(false);
    }


    void Start()
    {
        isMenuActive = false;

    }

    void Update()
    {

        OpenInGameMenu();

        if (Input.GetKeyDown(KeyCode.N))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isServer)
            {
                networkManager.StopHost();
                inGameMenuPanel.SetActive(false);
            }
            else
            {
                networkManager.StopClient();
                inGameMenuPanel.SetActive(false);
            }
        }

    }

    void OpenInGameMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !MenuScript.isMainMenuActive)
        {
            if (isMenuActive)
            {
                inGameMenuPanel.SetActive(false);
                isMenuActive = false;
            }
            else
            {
                inGameMenuPanel.SetActive(true);
                isMenuActive = true;
            }
        }

    }


    public void OnExitClick()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }

    public void OnReturnToMainMenuClick()
    {
        //SceneManager.LoadScene(mainMenuSceneName);
        //MenuScript.isMainMenuActive = false;

        if (isServer)
        {
            networkManager.StopHost();
            inGameMenuPanel.SetActive(false);
        }
        else
        {
            networkManager.StopClient();
            inGameMenuPanel.SetActive(false);
        }

    }

}
