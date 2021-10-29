using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class OldWeaponDamage : NetworkBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (isLocalPlayer)
        {
            if (collision.gameObject.tag.Equals("Player"))
            {

                Health.currentHealth += SwordMovement.attackDamage;
                Debug.Log(Health.currentHealth);

            }
        }
    }
}