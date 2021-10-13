using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDmg : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.tag.Equals("weapon"))
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Destroy(collision.gameObject);
            //transform.RotateAround(weapon.transform.position, Vector3.left, speed);
        }

    }
}
