using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTest : MonoBehaviour
{
 public GameObject target;
    public float speed = 5f;
    public static int attack;
    public static int damage;
    public int stamina = 100;
    public int w8 = 60;

    void Weapon()
    {
        if (Input.GetMouseButton(0))
        { 
            attack = 10;
            transform.RotateAround(target.transform.position, Vector3.right, speed);
            //print(attack);
        }
        if (Input.GetMouseButton(1))
        {
            attack = 20;
            transform.RotateAround(target.transform.position, Vector3.up, speed);
            //print(attack);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            attack = 30;
            transform.RotateAround(target.transform.position, Vector3.forward, speed);
            //print(attack);
        }


        //    TakingDmg.instance.HeavyAttack();
        //    //GetComponent<TakingDmg>().HeavyAttack();

    }
    void Update()
    {
        Weapon();
        
    }
}
