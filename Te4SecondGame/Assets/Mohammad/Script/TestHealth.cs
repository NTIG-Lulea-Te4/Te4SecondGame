using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHealth : MonoBehaviour
{
    public int stamina = 100;
    //public float delay = 2;

    void OnTriggerEnter(Collider colider)
    {
        if (colider.gameObject.tag == "weapon")
        {
            Destroy(gameObject);
            //stamina -= SwordMovement.attack;
            //print(stamina);
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
        if (stamina <= 0)
        {
            Destroy(gameObject);
        }
    }
}
