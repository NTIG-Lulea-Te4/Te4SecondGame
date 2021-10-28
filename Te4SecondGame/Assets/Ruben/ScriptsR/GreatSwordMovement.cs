using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GreatSwordMovement : NetworkBehaviour
{
    Animator animate;
    public bool greatSwordLight;
    public bool greatSwordParry;
    public bool greatSwordHeavy;
    public bool greatSwordSpecial;


    // Start is called before the first frame update

    
    
    
    void Start()
    {
        animate = GetComponent<Animator>();
        greatSwordLight = animate.GetBool("greatSwordLight");
        greatSwordHeavy = animate.GetBool("greatSwordHeavy");
        greatSwordParry = animate.GetBool("greatSwordParry");
        greatSwordSpecial = animate.GetBool("greatSwordSpecial");
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1") && greatSwordLight == false && hasAuthority)
        {
            animate.SetBool("greatSwordLight", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("greatSwordLight", false);

        }


        if (Input.GetButtonDown("Fire2") && greatSwordHeavy == false)
        {
            animate.SetBool("greatSwordHeavy", true);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("greatSwordHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && greatSwordSpecial == false)
        {
            animate.SetBool("greatSwordSpecial", true);

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("greatSwordSpecial", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && greatSwordParry == false)
        {
            animate.SetBool("greatSwordParry", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animate.SetBool("greatSwordParry", false);
        }
    }

}