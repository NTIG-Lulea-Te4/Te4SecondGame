using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapsdmg : MonoBehaviour
{
    public static int trapDamage = 20;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Health.health -= trapDamage;
            Debug.Log(Health.health);
        }
        Debug.Log("tasd");
    }

}
