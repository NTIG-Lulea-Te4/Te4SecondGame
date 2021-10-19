using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{


    [SerializeField]
    private GameObject inGameMenu;


    bool isEscapedPressed;


    static public void OnExitClick()
    {
        Application.Quit();
    }

    void Start()
    {
        isEscapedPressed = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isEscapedPressed = !isEscapedPressed;
        }

        if (isEscapedPressed)
        {
            inGameMenu.SetActive(true);

        }
        else if (!isEscapedPressed)
        {
            inGameMenu.SetActive(false);
        }

    }



}
