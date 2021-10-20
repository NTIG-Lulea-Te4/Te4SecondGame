using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TestHealth : MonoBehaviour
{
    public static int health = 100;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("weapon"))
        //if (collision.collider.tag == "weapon")
        {

            health -= SwordMovement.attackDamage;
            Debug.Log(health);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
