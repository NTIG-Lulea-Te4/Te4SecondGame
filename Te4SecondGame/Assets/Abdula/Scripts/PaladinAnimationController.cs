using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinAnimationController : MonoBehaviour
{
    Animator animator;
    float velocityX;
    float velocityZ;

    float acceleration;
    float deceleration;

    float maximumWalkVelocity;
    float maximumRunVelocity;

    public PaladinAnimationController()
    {
        velocityX = 0.0f;
        velocityZ = 0.0f;

        acceleration = 3.5f;
        deceleration = 4.0f;

        maximumWalkVelocity = 0.5f;
        maximumRunVelocity = 1.0f;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        bool runPressed = Input.GetKey("left shift");

        float currentMaxVelocity = runPressed ? maximumRunVelocity : maximumWalkVelocity;

        if (forwardPressed && velocityZ < 0.5f && !runPressed)
        {
            velocityZ += Time.deltaTime * acceleration;
        }

        if (rightPressed && velocityX < -0.5f && !runPressed)
        {
            velocityX += Time.deltaTime * acceleration;
        }

        if (leftPressed && velocityX < 0.5f && !runPressed)
        {
            velocityX -= Time.deltaTime * acceleration;
        }


        if(!forwardPressed && velocityZ > 0.0f)
        {
            velocityZ -= Time.deltaTime * deceleration;
        }

        if(!forwardPressed && velocityZ < 0.0f)
        {
            velocityZ = 0.0f;
        }


        if(!leftPressed && velocityX < 0.0f)
        {
            velocityX += Time.deltaTime * deceleration;
        }

        if(!rightPressed && velocityX > 0.0f)
        {
            velocityX -= Time.deltaTime * deceleration;
        }


        if(!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.5f && velocityX < 0.5f))
        {
            velocityX = 0.0f;
        }
        animator.SetFloat("velocity Z", velocityZ);
        animator.SetFloat("velocity X", velocityX);
    }
}
