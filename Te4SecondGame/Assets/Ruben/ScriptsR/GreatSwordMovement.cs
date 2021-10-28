using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatSwordMovement : MonoBehaviour
{
    Animator animate;
    public static bool greatSwordLight;
    public bool greatSwordParry;
    public bool greatSwordHeavy;
    public bool greatSwordSpecial;
    private float currentTime;
    private float startingTime;
    public static int greatSwordDamage;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 1f;
        startingTime = 0f;
        currentTime = startingTime;
        animate = GetComponent<Animator>();
        greatSwordLight = animate.GetBool("greatSwordLight");
        greatSwordHeavy = animate.GetBool("greatSwordHeavy");
        greatSwordParry = animate.GetBool("greatSwordParry");
        greatSwordSpecial = animate.GetBool("greatSwordSpecial");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && greatSwordLight == false)
        {
            animate.SetBool("greatSwordLight", true);
            greatSwordDamage = -20;
            Debug.Log(greatSwordDamage);

        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("greatSwordLight", false);

            currentTime += 1f * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire2") && greatSwordHeavy == false)
        {
            animate.SetBool("greatSwordHeavy", true);
            greatSwordDamage = -25;
            Debug.Log(greatSwordDamage);

        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("greatSwordHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && greatSwordSpecial == false)
        {
            animate.SetBool("greatSwordSpecial", true);
            greatSwordDamage = -15;



        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("greatSwordSpecial", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && greatSwordParry == false)
        {
            animate.SetBool("greatSwordParry", true);
            greatSwordDamage = 0;
            Debug.Log(greatSwordDamage);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animate.SetBool("greatSwordParry", false);
        }
    }
}

