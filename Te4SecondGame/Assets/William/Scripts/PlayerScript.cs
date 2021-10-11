using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    Vector3 movementX;
    Vector3 movementZ;
    Vector3 movementJump;
    Rigidbody playerRigidBody;

    float cooldown;
    float cooldownCounter;

    void Start()
    {
        movementX = new Vector3(5, 0, 0);
        movementZ = new Vector3(0, 0, 5);
        movementJump = new Vector3(0, 5, 0);
        playerRigidBody = GetComponent<Rigidbody>();

        cooldownCounter = 2;
        cooldown = 2;
    }

    

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            playerRigidBody.AddForce(movementX * -1);

        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRigidBody.AddForce(movementX);

        }


        if (Input.GetKey(KeyCode.A))
        {
            playerRigidBody.AddForce(movementZ * -1);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRigidBody.AddForce(movementZ);

        }

        cooldownCounter += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && cooldownCounter >= cooldown)
        {
            cooldownCounter = 0;
            playerRigidBody.AddForce(movementJump);

        }

    }
}
