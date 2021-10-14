using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float Timer = 1f;

    void Start()
    {
        Destroy(gameObject, Timer);
        
    }

}
