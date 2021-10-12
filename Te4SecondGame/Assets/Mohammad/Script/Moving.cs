using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Moving : NetworkBehaviour
{

    public float speed;
    // Start is called before the first frame update

    void Movement()
    {
         if (isLocalPlayer)
         {
             if (Input.GetKey(KeyCode.W))
             {
                 //transform.translate = transform.TransformDirection(Vector3.forward * speed);
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
        /*if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movment = new Vector3(moveHorizontal * 1, moveVertical, 0);
            transform.position = transform.position + movment;
        }*/
    }

    void Update()
    {
        Movement();
    }
}
