using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : NetworkBehaviour
{

    [SerializeField]
    private GameObject inGameMenuPanel;

    [Scene]
    public string mainMenuSceneName;

    bool isMenuActive;

    private void Awake()
    {

    }


    void Start()
    {
        isMenuActive = false;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName(mainMenuSceneName))
        {

            if (Input.GetKeyDown(KeyCode.Escape))
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
    }
    public void OnExitClick()
    {
        Application.Quit();

    }

    public void OnReturnToMainMenuClick()
    {
        SceneManager.LoadScene(mainMenuSceneName);
        //inGameMenuCanvas.SetActive(false);

    }

}
