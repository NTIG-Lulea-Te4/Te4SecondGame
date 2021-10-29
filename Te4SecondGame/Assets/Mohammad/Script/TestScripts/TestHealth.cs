using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TestHealth : MonoBehaviour
{
    private int startAihleath = 100;
    private int currentAihleath;
    //private int tDmg = -50;

    void Start()
    {
        currentAihleath = startAihleath;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Trap"))
        {
            currentAihleath += Trapsdmg.trapDamage;
            
        }
        if (other.gameObject.tag.Equals("weapon"))
        {
            currentAihleath += BonkMovement.weaponDamage;
            
        }
        if (other.gameObject.tag.Equals("weapon"))
        {
            currentAihleath += SwordAndShieldMovement.sAO;
            
        }
        if (other.gameObject.tag.Equals("weapon"))
        {
            currentAihleath += AxeMovement.axeDmg;
            
        }
        if (other.gameObject.tag.Equals("GreatSwrodID"))
        {
            currentAihleath += GreatSwordMovement.greatSwordDamage;


        }
        Debug.Log(currentAihleath);
    }

    void Update()
    {
        if (currentAihleath <= 0)
        {
            Destroy(gameObject);
            GetComponent<Effect>().Death();
        }
    }
        

}
