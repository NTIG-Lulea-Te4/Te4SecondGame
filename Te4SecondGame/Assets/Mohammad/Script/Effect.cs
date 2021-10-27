using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Effect : MonoBehaviour
{
    public GameObject blood;
    public GameObject death;
    public TextMeshPro damageText;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("weapon"))
        {
            Instantiate(blood, transform.position, transform.rotation);
            damageText.text = SwordMovement.attackDamage.ToString();
            Instantiate(damageText, new Vector3(transform.position.x + 3, transform.position.y, transform.position.z), transform.rotation);
            
        }
        if (collision.gameObject.tag.Equals("Trap"))
        {
            Instantiate(blood, transform.position, transform.rotation);
            damageText.text = Trapsdmg.trapDamage.ToString();
            Instantiate(damageText, new Vector3(transform.position.x + 3, transform.position.y, transform.position.z), transform.rotation);
            
        }

    }

    public void Dying()
    {
        Instantiate(death, transform.position, transform.rotation);

    }
}
