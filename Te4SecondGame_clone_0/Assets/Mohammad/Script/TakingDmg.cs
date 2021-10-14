using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDmg : MonoBehaviour
{
    public float healthAmount = 100;
    //public TakingDmg instance;
    public GameObject target;
    public float speed = 5f;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("lightAttack"))
        {
            healthAmount -= 20;
            print("-20");
        }

        if (healthAmount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
        //    if (Input.GetMouseButton(0))
        //    {
        //        transform.RotateAround(target.transform.position, Vector3.right, speed);

        //        if (collision.gameObject.tag.Equals("enemy"))
        //        {
        //            healthAmount -= 20;
        //            print("-20");
        //        }
        //        //if (collision.gameObject.tag.Equals("enemy"))
        //        //{
        //        //    if (Input.GetMouseButton(0))
        //        //    {
        //        //        transform.RotateAround(target.transform.position, Vector3.right, speed);
        //        //        healthAmount -= 20;
        //        //        print("-20");
        //    }
        //        if (Input.GetMouseButton(1))
        //        {
        //            transform.RotateAround(target.transform.position, Vector3.up, speed);
        //            healthAmount -= 50;
        //            print("-50");
        //        }

        //    if (healthAmount <= 0)
        //    {
        //        Destroy(gameObject);
        //    }
        //}

        //public void LightAttack()
        //{
        //    healthAmount -= 20;
        //    print("-20");
        //}
        //public void HeavyAttack()
        //{
        //    healthAmount -= 50;
        //    print("-50");
        //}


        /*void OnTriggerEnter(Collider colider)
        {
            if (colider.gameObject.tag == "weapon")
            {
                //healthAmount -= 100;
                print("dmg");
                Destroy(gameObject);
            }
        }*/


//    }
//    public void Awake()
//    {
//        instance = this;
//    }


//}
