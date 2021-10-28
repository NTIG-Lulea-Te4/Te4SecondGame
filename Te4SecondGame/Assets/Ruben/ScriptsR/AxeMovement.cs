using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMovement : MonoBehaviour
{
    Animator animate;
    public bool axeLight;
    public bool axeHeavy;
    public bool axeParry;
    public bool axeSpecial;
    public static int weaponOuch;

    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        //BonkMovement.weaponDamage = weaponOuch;
        axeParry = animate.GetBool("axeParry");
        axeLight = animate.GetBool("axeLight");
        axeHeavy = animate.GetBool("axeHeavy");
        axeSpecial = animate.GetBool("axeSpecial");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && axeLight == false)
        {
            animate.SetBool("axeLight", true);
            weaponOuch = -5;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("axeLight", false);
            
        }

        if (Input.GetButtonDown("Fire2") && axeHeavy == false)
        {
            animate.SetBool("axeHeavy", true);
            weaponOuch = -20;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("axeHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && axeSpecial == false)
        {
            animate.SetBool("axeSpecial", true);
            weaponOuch = -10;

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("axeSpecial", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && axeParry == false)
        {
            animate.SetBool("axeParry", true);
            weaponOuch = 0;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animate.SetBool("axeParry", false);
        }
    }
}
