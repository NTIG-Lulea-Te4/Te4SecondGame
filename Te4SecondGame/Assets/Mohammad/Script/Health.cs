using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Health : NetworkBehaviour
{
    public static int health = 100;

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag.Equals("Trap"))
    //    {

    //        Health.health -= Trapsdmg.trapDamage;
    //        Debug.Log(Health.health);
    //    }
    //}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Trap"))
        {
           
        }
        Debug.Log("Trap");
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
