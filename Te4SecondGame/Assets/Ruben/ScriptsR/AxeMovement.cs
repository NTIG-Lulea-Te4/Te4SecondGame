using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMovement : MonoBehaviour
{
    Animator animate;
    public bool axeLight;
    public bool axeHeavy;
    public bool axeSpecial;
    public bool axeParry;
    public float currentTime;
    public float startingTime;
    public string currentState;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 1f;
        startingTime = 0f;
        currentTime = startingTime;
        animate = GetComponent<Animator>();
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
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("axeLight", false);

            currentTime += 1f * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire2") && axeHeavy == false)
        {
            animate.SetBool("axeHeavy", true);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("axeHeavy", false);

        }

        if (Input.GetButtonDown("Fire3") && axeSpecial == false)
        {
            animate.SetBool("axeSpecial", true);

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("axeSpecial", false);

        }
    }
}
