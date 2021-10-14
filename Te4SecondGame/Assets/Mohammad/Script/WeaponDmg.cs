using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDmg : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
