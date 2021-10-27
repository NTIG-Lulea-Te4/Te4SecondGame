using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moevment : MonoBehaviour
{
    public static Moevment instance;
    static int rotationspeed = 200;
    public  float speed = 200;
    private  Rigidbody rigidbody;
    string turnedLeft;
    string turnedRightText;
    static string savedData;
    float turnedLeftData;
    float turnedRightData;
    Vector3 movedForward;
    float timer;
    bool hasCollied;

    // Start is called before the first frame update

    public void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Outer Wall" || collision.gameObject.tag == "Horizontal Inner Wall"))
        {
            Debug.Log("Daniel");

        }

    }
    public void IfIsInCorner()
    {
        if (FrontSencor.frontSencorInformatio <= 0.5 && RightSencor.rightSencorInformation <= 0.5 && LeftSencor.leftSencorInformatin <= 0.5)
        {
            hasCollied = true;

        }
    }
    private void Awake()
    {
        instance = this;
        rigidbody = GetComponent<Rigidbody>();
    }

    public void ForwardMovement()
    {
        Vector3 forward = -transform.forward * speed * Time.deltaTime / 10;
        rigidbody.MovePosition(rigidbody.position + forward);


        savedData = "MovedForward";
        movedForward = rigidbody.position + forward;
        Entity Forward = new Entity(savedData, movedForward);
        timer += Time.deltaTime;
        if (timer > 3)
        {

            EntityManager.AddAtTheEnd(Forward);
            timer = 0;
        }
    }
    public void TurnRight()
    {
        float turn = rotationspeed * speed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn / 2, 0f);
        rigidbody.MoveRotation(rigidbody.rotation * turnRotation);
        turnedRightData = turn;
        turnedRightText = "Went Right";
        Entity left = new Entity(turnedRightText, turnedRightData);
        EntityManager.AddAtTheEnd(left);
    }
    public void TurnLeft()
    {
        float turnL = -rotationspeed * speed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turnL / 2, 0f);
        rigidbody.MoveRotation(rigidbody.rotation * turnRotation);
        turnedLeftData = turnL;
        turnedLeft = "Went Left";
        Entity right = new Entity(turnedLeft, turnedLeftData);
        EntityManager.AddAtTheEnd(right);
    }

    public void Movement()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            if (FrontSencor.frontSencorInformatio > LeftSencor.leftSencorInformatin && FrontSencor.frontSencorInformatio > RightSencor.rightSencorInformation)
            {
                transform.Rotate(0, 0, 0);
                Debug.Log("Front");
                //Debug.Log(FrontSencor.frontSencorInformatio + "front");
                //Debug.Log(FrontSencor.frontSencorInformatio + " Front" + LeftSencor.leftSencorInformatin + " Left" + RightSencor.rightSencorInformation + "Right");
            }
            else if (LeftSencor.leftSencorInformatin > RightSencor.rightSencorInformation && LeftSencor.leftSencorInformatin > FrontSencor.frontSencorInformatio)
            {
                TurnLeft();
                Debug.Log("Left Rotation");
                Debug.Log(FrontSencor.frontSencorInformatio + " Front " + LeftSencor.leftSencorInformatin + " Left " + RightSencor.rightSencorInformation + "Right");
                //Debug.Log(LeftSencor.leftSencorInformatin + "left");
            }
            else if (RightSencor.rightSencorInformation > LeftSencor.leftSencorInformatin && RightSencor.rightSencorInformation > FrontSencor.frontSencorInformatio)
            {
                TurnRight();
                Debug.Log("Right Rotation");
                Debug.Log(FrontSencor.frontSencorInformatio + " Front" + LeftSencor.leftSencorInformatin + " Left" + RightSencor.rightSencorInformation + "Right");
                //Debug.Log(RightSencor.rightSencorInformation + "right");
            }
            timer = 0;
        }
        if (hasCollied == false)
        {

            ForwardMovement();
        }
        EntityManager.Print();

    }
    void FixedUpdate()
    {
        Movement();
        IfIsInCorner();
    }
}
