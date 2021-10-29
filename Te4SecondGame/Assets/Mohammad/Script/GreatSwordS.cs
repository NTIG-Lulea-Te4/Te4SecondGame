using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatSwordS : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("EnemyAI"))
        {
            //AiHealth.currentAihleath += GreatSwordMovement.greatSwordDamage;
            //Debug.Log(AiHealth.currentAihleath);
        }
        //public void OnTriggerStay(Collider other)
        //    {
        //        if (other.gameObject.tag == "EnemyAI") {GreatSwordMovement.greatSwordLight = true; }
        //        else if (other.gameObject.tag != "EnemyAI") { GreatSwordMovement.greatSwordLight = false; }
        //    }
    }

}