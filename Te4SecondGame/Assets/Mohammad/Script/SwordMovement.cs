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
    public int stamina = 100;
    //public static Vector3 startPos;


    void Weapon()
    {
        if (Input.GetMouseButton(0))
        { 
            attackDamage = 10;
            transform.RotateAround(target.transform.position, Vector3.right, speed);
        }
        if (Input.GetMouseButton(1))
        {
            attackDamage = 20;
            transform.RotateAround(target.transform.position, Vector3.up, speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            attackDamage = 30;
            transform.RotateAround(target.transform.position, Vector3.forward, speed);
        }
    }
    void Update()
    {
        Weapon();
    }

}
//public void StartPosition()
//{
//    startPos = transform.position;
//}

//    TakingDmg.instance.HeavyAttack();
//    //GetComponent<TakingDmg>().HeavyAttack();

//public void Awake()
//{
//    instance = this;
//}







