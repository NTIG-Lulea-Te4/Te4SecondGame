using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapsdmg : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Ouchhh");
            Health.health -= 20;
            Debug.Log(Health.health);

        }
    }

}
