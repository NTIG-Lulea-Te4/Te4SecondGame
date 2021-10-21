using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public float trapheal = 100;
    public float trapdmg;
    public GameObject trapNeedle;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(trapNeedle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag.Equals("Player"))
    //    {
    //        //Destroy(gameObject);

    //        //trapdmg = 20;
    //        //Destroy(gameObject);
    //        //Debug.Log("Ouchhh");
    //        //Health.health -= 30;
    //        Debug.Log("hit trap");
    //        Instantiate(trapNeedle, transform.position, transform.rotation);

    //    }
    //}
}
