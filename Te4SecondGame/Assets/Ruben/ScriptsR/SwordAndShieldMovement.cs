using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAndShieldMovement : MonoBehaviour
{
    Animator animate;
    public bool swordLight;
    public bool shieldParry;
    public bool swordAndShieldHeavy;
    public bool swordAndShieldSpecial;
    public static int sAO;



    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        swordLight = animate.GetBool("swordLight");
        shieldParry = animate.GetBool("shieldParry");
        swordAndShieldHeavy = animate.GetBool("swordHeavy");
        swordAndShieldSpecial = animate.GetBool("specialHit");
    }


    // Update is called once per frame
    void Update()
    {
        //BonkMovement.weaponDamage = SAO;
        if (Input.GetButtonDown("Fire1") && swordLight == false)
        {
            animate.SetBool("swordLight", true);
            sAO = -10;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("swordLight", false);
        }

        if (Input.GetButtonDown("Fire2") && swordAndShieldHeavy == false)
        {
            animate.SetBool("swordHeavy", true);
            sAO = -20;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("swordHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && swordAndShieldSpecial == false)
        {
            animate.SetBool("specialHit", true);
            sAO = -30;

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("specialHit", false);

        }

        if (Input.GetKeyDown(KeyCode.Q) && shieldParry == false)
        {
            animate.SetBool("shieldParry", true);
            sAO = 0;
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            animate.SetBool("shieldParry", false);
        }
    }
}
