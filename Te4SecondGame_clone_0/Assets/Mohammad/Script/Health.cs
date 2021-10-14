using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //public int stamina = 100;
    public int health = 100;


    //public float delay = 2;


    void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.tag.Equals("enemy"))
        {
            health -= SwordMovement.attackDamage;
            print(health);
            //originalPos = gameObject.transform.position;
            //gameObject.transform.position = SwordMovement.StartPoint;
            //if (SwordMovement.attack == 1 )
            //delay -= Time.deltaTime;
            //if(delay <= 0)
            //delay = 0;
            //if (SwordMovement.attack == 2)
            //    stamina -= 20;
            //if (SwordMovement.attack == 3)
            //    stamina -= 30;
        }
        if (health <= 0)
        {
            Destroy(collision.gameObject);
        }
    }
}
