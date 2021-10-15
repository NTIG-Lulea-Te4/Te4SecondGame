using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonkMovement : MonoBehaviour
{
    Animator animate;
    public bool attacking;
    public float currentTime;
    public bool isInteracting;
    public float startingTime;
    public string currentState;
    public const string PLAYER_HEAVY = "StopBonkHeavy";
    public const string PLAYER_SPECIAL = "StopBonkSpecial";
    public const string PLAYER_LIGHT_TWO = "StopBonkSecondHit";

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 1f;
        startingTime = 0f;
        attacking = animate.GetBool("attacking");
        isInteracting = animate.GetBool("isInteracting");
        animate = GetComponent<Animator>();
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1")  && isInteracting == false)
        //{
        //    ChangeAnimationState(PLAYER_LIGHT);
        //}
        if (Input.GetButtonDown("Fire1") && attacking == false)
        {
            animate.SetBool("attacking", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("attacking", false);
            
            currentTime += 1f * Time.deltaTime;
        }

        if (attacking == true)
        {
            isInteracting = true;
        }
        else
        {
            isInteracting = false;
        }


        if (currentTime < 1f * Time.deltaTime && Input.GetButton("Fire1"))
        {
            ChangeAnimationState(PLAYER_LIGHT_TWO);
        }

        if (Input.GetButtonDown("Fire2") && isInteracting == false)
        {
            ChangeAnimationState(PLAYER_SPECIAL);
        }

        if (Input.GetButtonDown("Fire3") && isInteracting == false)
        {
            ChangeAnimationState(PLAYER_HEAVY);

        }
    }

    void ChangeAnimationState(string newState)
    {
        //stop the same animation from interrupting itself.
        if (currentState != newState)
        {
            //play animation.
            animate.Play(newState);

            //reassign the current state.
            currentState = newState;

        }

    }
}

