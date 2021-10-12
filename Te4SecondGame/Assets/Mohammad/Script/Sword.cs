using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Sword : MonoBehaviour
{

    public GameObject target;
    public float speed = 5f;

    void Weapon()
    {



        if (Input.GetKey(KeyCode.Space))
        {
            transform.RotateAround(target.transform.position, Vector3.right, speed);
            //transform.Rotate(4, 0, 0, Space.World);
            //target = transform.TransformDirection(Vector3.forward * speed);
            //transform.Rotate(target.transform);
            //RotationDriveMode(target, transform.position, transform.rotation);
            //transform.RotateAround(target.transform.position, Vector3.right, speed);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
       // if (collision.gameObject.tag.Equals("weapon"))
       if (other.tag == "plane")
        {
            Destroy(gameObject);
            //transform.RotateAround(weapon.transform.position, Vector3.left, speed);
        }

    }

    void Update()
    {
        Weapon();
    }

}



