using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public GameObject blood;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("weapon"))
        {
            Instantiate(blood, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

        }
    }
}
