using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiHealth : MonoBehaviour
{
    public static int Aihleath = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("GreatSwordID"))
        {
            if (AiHealth.Aihleath <= 0)
            {
                Destroy(gameObject);
                GetComponent<Effect>().Death();
            }
        }
    }


}
