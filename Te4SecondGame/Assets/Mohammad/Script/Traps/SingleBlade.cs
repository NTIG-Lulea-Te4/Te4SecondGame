using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBlade : MonoBehaviour
{
    public GameObject SingleBladeActivating;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnDisable();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnEnable();
        }
    }
    public void OnDisable()
    {
        SingleBladeActivating.SetActive(true);
    }
    public void OnEnable()
    {
        SingleBladeActivating.SetActive(false);
    }
}
