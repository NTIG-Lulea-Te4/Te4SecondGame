using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontSencor : MonoBehaviour
{
    public float maxDistance;

    public static FrontSencor instance;
    public static float frontSencorInformatio;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        maxDistance = 15;
    }

    void FrontRay()
    {
        Vector3 direction = transform.right;
        Ray ray = new Ray(transform.position, direction);
        Debug.DrawRay(ray.origin, ray.direction*maxDistance, Color.red);

        RaycastHit hitFront;
        if (Physics.Raycast(transform.position, direction, out hitFront, maxDistance))
        {
            frontSencorInformatio = hitFront.distance;
           // Debug.Log(hitFront.collider.gameObject.name + frontSencorInformatio + " Front");
            //Moevment.instance.MoveForward();

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FrontRay();
    }

}
