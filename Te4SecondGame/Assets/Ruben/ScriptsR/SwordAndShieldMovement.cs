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


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 1f;
        startingTime = 0f;
        currentTime = startingTime;
        animate = GetComponent<Animator>();
        swordLight = animate.GetBool("swordLight");
        shieldParry = animate.GetBool("shieldParry");
        swordAndShieldHeavy = animate.GetBool("swordAndShieldHeavy");
        swordAndShieldSpecial = animate.GetBool("swordAndShieldSpecial");
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

            currentTime += 1f * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire2") && swordAndShieldHeavy == false)
        {
            animate.SetBool("swordAndShieldHeavy", true);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("swordAndShieldHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && swordAndShieldSpecial == false)
        {
            animate.SetBool("swordAndShieldSpecial", true);

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("swordAndShieldSpecial", false);

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
