using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Effect : MonoBehaviour
{
    public GameObject blood;
    public GameObject death;
    public TextMeshPro damageText;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("weapon"))
        {
            Instantiate(blood, transform.position, transform.rotation);
            Instantiate(damageText, new Vector3(transform.position.x + 1 , transform.position.y, transform.position.z), transform.rotation);
            damageText.text = SwordMovement.attackDamage.ToString();
        }
        if (Health.health <= 0)
        {
            Instantiate(death, transform.position, transform.rotation);
        }
    }
}
