using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{

    static GameObject singletonObject;
    int numberOfObjectsToNotDestroy;

    private void Update()
    {
        // Debug.Log(numberOfObjectsToNotDestroy);

    }

    private void Awake()
    {
        numberOfObjectsToNotDestroy = GameObject.FindGameObjectsWithTag("DontDestroy").Length;

        if (numberOfObjectsToNotDestroy > 2)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

        //if (singletonObject == null)
        //{
        //    singletonObject = this.gameObject;
        //    DontDestroyOnLoad(this.gameObject);
        //}
        //else if (singletonObject != this.gameObject)
        //{
        //    Destroy(this.gameObject);
        //}
    }
    
}
