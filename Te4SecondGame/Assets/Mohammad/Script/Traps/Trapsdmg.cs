using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapsdmg : MonoBehaviour
{
    public GameObject blood;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Health.health -= 20;
            Debug.Log(Health.health);
            Instantiate(blood, transform.position, transform.rotation);

        }
    }

}
