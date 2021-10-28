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

        if (Input.GetButtonDown("Fire1") && swordLight == false)
        {
            animate.SetBool("swordLight", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("swordLight", false);

        }

        if (Input.GetButtonDown("Fire2") && swordAndShieldHeavy == false)
        {
            animate.SetBool("swordHeavy", true);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("swordHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && swordAndShieldSpecial == false)
        {
            animate.SetBool("specialHit", true);

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("specialHit", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && shieldParry == false)
        {
            animate.SetBool("shieldParry", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animate.SetBool("shieldParry", false);
        }
    }
}
