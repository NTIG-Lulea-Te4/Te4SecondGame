using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class SwordMovement : MonoBehaviour
{

    public GameObject target;
    public float speed = 5f;
    public static int attackDamage;
    //public static int damage;
    public int stamina = 100;


    void Weapon()
    {
        if (Input.GetMouseButton(0))
        { 
            attackDamage = 10;
            transform.RotateAround(target.transform.position, Vector3.right, speed);
            //print(attack);
        }
        if (Input.GetMouseButton(1))
        {
            attackDamage = 20;
            transform.RotateAround(target.transform.position, Vector3.up, speed);
            //print(attack);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            attackDamage = 30;
            transform.RotateAround(target.transform.position, Vector3.forward, speed);
            //print(attack);
        }
    }
    void Update()
    {
        Weapon();
    }
}
//    TakingDmg.instance.HeavyAttack();
//    //GetComponent<TakingDmg>().HeavyAttack();

/*void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag.Equals("enemy"))
    {
        stamina -= attack;
        print(stamina);
    }
    if (stamina <= 0)
    {
        Destroy(collision.gameObject);
    }
}*/
/* public void dmg()
 {
     if (attack ==1)
     {
         damage = 20;
     }
     if (attack == 2)
     {
         damage = 30;
     }
     if (attack == 3)
     {
         damage = 40;
     }
 }
 */

/* void OnCollisionEnter(Collision collision)
 {
     if (collision.gameObject.tag.Equals("enemy"))
     {
         w8--;
         if (attack ==1 && w8 <=0)
             stamina -= 10;
         w8 = 0;

         if (attack == 2)
             stamina -= 20;

         if (attack == 3)
             stamina -= 30;

         print(stamina);
     }
     if (stamina <= 0)
     {
         Destroy(collision.gameObject);
     }
 }
*/





