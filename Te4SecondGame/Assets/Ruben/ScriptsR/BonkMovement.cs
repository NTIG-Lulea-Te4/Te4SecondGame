using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonkMovement : MonoBehaviour
{
    public float startingTime = 0f;
    public float currentTime = 0.5f;
    Animator animate;
    public string currentState;

    public const string PLAYER_HEAVY = "StopBonkHeavy";
    //public const string PLAYER_LIGHT = "StopBonk";

    void ChangeAnimationState(string newState)
    {

        //stop the same animation from interrupting itself.
        if (currentState == newState)
        {
            return;
        }

        //play animation.
        animate.Play(newState);

        //reassign the current state.
        currentState = newState;
    }

    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire3") /* && isInteracting = false*/)
        //{
        //    ChangeAnimationState(PLAYER_LIGHT);
        //}
        if (Input.GetButtonDown("Fire1"))
        {
            animate.SetBool("attacking", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("attacking", false);
            //if (isInteracting = false)
            //{
            //  currentTime += 0.5f * Time.deltaTime;
            //}
        }
        // when animation end, initiate below.


        if (currentTime < 0.5f * Time.deltaTime)
        {
            //initate animation 2
        }


        if (Input.GetButtonDown("Fire3") /* && isInteracting = false*/)
        {
            ChangeAnimationState(PLAYER_HEAVY);
            
        }
    }
}
