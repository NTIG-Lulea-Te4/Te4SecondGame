using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public CharacterController controller;
    Vector3 direction;
    float turnSmoothlySpeed;
    float turnSmoothlyTime;
    float faceThisWayAngle;
    float faceThisWaySmoothly;
    float speed;
    float axisHorizontal;
    float axisVertical;
    // Start is called before the first frame update
    void Start()
    {

        turnSmoothlyTime = 0.1f;
        speed = 6f;
    
    }

    // Update is called once per frame
    void Update()
    {
        axisHorizontal = Input.GetAxis("Horizontal");
        axisVertical = Input.GetAxis("Vertical");
        direction = new Vector3(axisHorizontal, 0f, axisVertical).normalized;

        if (direction.magnitude >= 0.1f)
        {

            faceThisWayAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            faceThisWaySmoothly = Mathf.SmoothDampAngle(transform.eulerAngles.y, faceThisWayAngle, ref turnSmoothlySpeed, turnSmoothlyTime);
            transform.rotation = Quaternion.Euler(0f, faceThisWaySmoothly, 0f);

            controller.Move(direction * speed * Time.deltaTime);
        }

    }
}
