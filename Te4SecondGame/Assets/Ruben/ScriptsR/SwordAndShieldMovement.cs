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
    private float currentTime;
    private float startingTime;
    public static int SAO;



    // Start is called before the first frame update
    void Start()
    {
        currentTime = 1f;
        startingTime = 0f;
        currentTime = startingTime;
        animate = GetComponent<Animator>();
        swordLight = animate.GetBool("swordLight");
        shieldParry = animate.GetBool("shieldParry");
        swordAndShieldHeavy = animate.GetBool("swordHeavy");
        swordAndShieldSpecial = animate.GetBool("specialHit");
    }


    // Update is called once per frame
    void Update()
    {
        BonkMovement.weaponDamage = SAO;
        if (Input.GetButtonDown("Fire1") && swordLight == false)
        {
            animate.SetBool("swordLight", true);
            SAO = -10;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("swordLight", false);

            currentTime += 1f * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire2") && swordAndShieldHeavy == false)
        {
            animate.SetBool("swordHeavy", true);
            SAO = -20;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("swordHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && swordAndShieldSpecial == false)
        {
            animate.SetBool("specialHit", true);
            SAO = -30;

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("specialHit", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && shieldParry == false)
        {
            animate.SetBool("shieldParry", true);
            SAO = 0;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animate.SetBool("shieldParry", false);
        }
    }
}
