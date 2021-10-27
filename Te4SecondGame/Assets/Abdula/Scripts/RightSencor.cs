using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSencor : MonoBehaviour
{
    public float maxDistance;
    public static RightSencor instance;
    public static float rightSencorInformation;
    // Start is called before the first frame update
    void Start()
    {
        maxDistance = 14;
    }

    private void Awake()
    {
        instance = this;
    }
    public void RighRay()
    {
        Vector3 direction = transform.right;
        Ray ray = new Ray(transform.position, transform.right);
        Debug.DrawRay(ray.origin, ray.direction*maxDistance, Color.red);

        RaycastHit hitRight;
        if (Physics.Raycast(transform.position, direction, out hitRight))
        {
            rightSencorInformation = hitRight.distance;
            //Debug.Log(hitRight.collider.gameObject.name + rightSencorInformation+ "   right");
            //Moevment.instance.MoveForward();
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        RighRay();
        
    }
}
