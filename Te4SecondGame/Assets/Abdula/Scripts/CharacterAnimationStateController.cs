using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationStateController : MonoBehaviour
{
    Animator animator;
    float velocity;
    int velocityHash;

    [SerializeField]
    private float acceleration;

    [SerializeField]
    private float deceleration;

    public CharacterAnimationStateController()
    {
        velocity = 0.0f;

        acceleration = 3.5f;
        deceleration = 4.0f;
    }

    void Start()
    {
        animator = GetComponent<Animator>();

        velocityHash = Animator.StringToHash("Velocity");
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!forwardPressed && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if (!forwardPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        animator.SetFloat(velocityHash, velocity);

        //if (runPressed)
        //{
        //    velocity += Time.deltaTime * acceleration;
        //}
    }
}
