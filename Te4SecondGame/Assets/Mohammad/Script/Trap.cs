using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float trapheal = 100;
    public float trapdmg;
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //        Health.health -= 20;
    //        Debug.Log("health -20");
    //    }
    //}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            //Destroy(gameObject);

            //trapdmg = 20;
            die();

        }
        //trapheal -= trapdmg;
        //Debug.Log(trapheal);
    }

    void die()
    {
        Destroy(gameObject);
        Debug.Log("Ouchhh");
    }
    void Update()
    {
        die();
        
    }
}
