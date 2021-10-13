using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class SwordMovement : MonoBehaviour
{

    public GameObject target;
    public float speed = 5f;

    void Weapon()
    {
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(target.transform.position, Vector3.right, speed);

        }
        //if (Input.GetMouseButton(1))
        //{
        //    transform.RotateAround(target.transform.position, Vector3.up, speed);

        //}

        //}

        //if (Input.GetMouseButton(1))
        //{
        //    transform.RotateAround(target.transform.position, Vector3.up, speed);
        //    TakingDmg.instance.HeavyAttack();
        //    //GetComponent<TakingDmg>().HeavyAttack();
        //}


    }

    void Update()
    {
        Weapon();
    }



}



