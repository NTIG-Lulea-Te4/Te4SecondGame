using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeaponDamage : MonoBehaviour
{
    public int TestWeapndmg = -10;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            TestHealth.health += TestWeapndmg;
            Debug.Log(TestHealth.health);
        }
    }
}
