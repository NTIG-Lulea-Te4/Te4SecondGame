using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int startHealth = 100;
    public static int currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            GetComponent<Effect>().Death();
            Debug.Log("Wtf");

        }
    }
}
