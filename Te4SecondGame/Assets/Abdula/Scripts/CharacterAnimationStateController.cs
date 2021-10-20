using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationStateController : MonoBehaviour
{
    Animator animator;
    bool isWalking;
    bool forwardPressed;



    public CharacterAnimationStateController()
    {
       //isWalking = animator.GetBool("isWalking");
       //forwardPressed = Input.GetKey("W");
    }


    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            animator.SetBool("isWalking", true);
        }
        
        if (Input.GetKeyUp("w"))
        {
            animator.SetBool("isWalking", false);
        }


        //if (Input.GetKeyDown("Left Shift"))
        //{
        //    animator.SetBool("isRunning", true);
        //}

        //if (Input.GetKeyUp("Left Shift"))
        //{
        //    animator.SetBool("isRunning", false);
        //}
    }
}
