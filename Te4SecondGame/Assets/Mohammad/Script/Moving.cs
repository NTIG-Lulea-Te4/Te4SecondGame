using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Moving : NetworkBehaviour
{

    public float speed;


    void Movement()
    {
         if (isLocalPlayer)
         {
             if (Input.GetKey(KeyCode.W))
             {
                 transform.Translate(Vector3.forward * speed * Time.deltaTime);
             }
             if (Input.GetKey(KeyCode.S))
             {
                 transform.Translate(Vector3.back * speed * Time.deltaTime);
             }
             if (Input.GetKey(KeyCode.A))
             {
                 transform.Translate(Vector3.left * speed * Time.deltaTime);
             }
             if (Input.GetKey(KeyCode.D))
             {
                 transform.Translate(Vector3.right * speed * Time.deltaTime);
             }
         }
    }

    void Update()
    {
        Movement();
    }
}
