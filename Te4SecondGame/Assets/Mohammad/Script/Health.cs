using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int health = 100;

    void Update()
    {
        if (health <= 0)
        {
            GetComponent<Effect>().Dying();
            Destroy(gameObject);
        }
    }
}
