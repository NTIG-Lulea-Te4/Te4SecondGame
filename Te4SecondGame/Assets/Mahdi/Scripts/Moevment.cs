using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moevment : MonoBehaviour
{
    public static Moevment instance;
    int flag;
    // Start is called before the first frame update


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
       
    }


    public void MoveForward()
    {
        if (FrontSencor.frontSencorInformatio > LeftSencor.leftSencorInformatin && FrontSencor.frontSencorInformatio > RightSencor.rightSencorInformation)
        {
            transform.Rotate(0, 0, 0);
            Debug.Log("Front");
        }
        else if (LeftSencor.leftSencorInformatin > FrontSencor.frontSencorInformatio && LeftSencor.leftSencorInformatin > RightSencor.rightSencorInformation)
        {
            transform.Rotate(0, -10 , 0);
            Debug.Log("Left Rotation");

        }
        else if (RightSencor.rightSencorInformation > LeftSencor.leftSencorInformatin && RightSencor.rightSencorInformation > FrontSencor.frontSencorInformatio)
        {
            transform.Rotate(0, 10, 0);

            //Debug.Log(FrontSencor.frontSencorInformatio + " Front" + LeftSencor.leftSencorInformatin + " Left" + RightSencor.rightSencorInformation + "Right");
            Debug.Log("Right Rotation");
        }
        Vector3 fwd = (transform.rotation * Vector3.back *Time.deltaTime) / 20;
        transform.position += fwd.normalized;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        MoveForward();
    }
}
