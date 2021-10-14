using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int health = 100;
    //public Effect instance;
    //public SwordMovement swordMovement;

    void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.tag.Equals("enemy"))
        {
            health -= SwordMovement.attackDamage;
            print(health);


            //transform.position = swordMovement.StartPosition();
            //originalPos = gameObject.transform.position;
            //gameObject.transform.position = SwordMovement.StartPoint;

        }
        if (health <= 0)
        {
            Destroy(collision.gameObject);
        }
    }
}
