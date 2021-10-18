using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSencor : MonoBehaviour
{

    public static LeftSencor instance;
    public float maxDistance;
    public static float leftSencorInformatin;
    RaycastHit hitLeft;
    // Start is called before the first frame update
    void Start()
    {
        maxDistance = 5;
    }

    private void Awake()
    {
        instance = this;
    }


    public void LeftRay()
    {
        Vector3 direction = transform.right;
        Ray ray = new Ray(transform.position, transform.right);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        
        if (Physics.Raycast(transform.position, direction, out hitLeft, maxDistance))
        {

            leftSencorInformatin= hitLeft.distance;
            //Debug.Log(hitLeft.collider.gameObject.name +  hitLeft.distance+ "   LEft");
            //Moevment.instance.MoveForward();
        }
    }
    void FixedUpdate()
    {
        LeftRay();
        
    }
}
