using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject inGameMenu;

    [Scene]
    public string mainMenuSceneName;


    bool isMenuActive;



    void Start()
    {
        isMenuActive = false;
    }

    void Update()
    {
        // != ????
        if (SceneManager.GetActiveScene().name != mainMenuSceneName)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isMenuActive)
                {
                    inGameMenu.SetActive(false);
                    isMenuActive = false;
                }
                else
                {
                    inGameMenu.SetActive(true);
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

    }

}
