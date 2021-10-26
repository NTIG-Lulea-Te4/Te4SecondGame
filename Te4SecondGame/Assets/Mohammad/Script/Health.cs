using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Health : NetworkBehaviour
{
    public static int health = 500;

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag.Equals("Trap"))
    //    {

    //        Health.health -= Trapsdmg.trapDamage;
    //        Debug.Log(Health.health);
    //    }
    //}

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
