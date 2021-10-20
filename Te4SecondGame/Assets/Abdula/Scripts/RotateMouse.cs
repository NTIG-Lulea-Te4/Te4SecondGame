using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class RotateMouse : NetworkBehaviour
{
    [SerializeField]
    private float rotateSpeed;
    private float hitDistance;
    Plane playerplane;
    Ray ray;

    public RotateMouse()
    {
        rotateSpeed = 10f;
        playerplane = new Plane(new Vector3(0, 1, 0), transform.position);
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    void LookAtMouse()
    {
        if(playerplane.Raycast(ray, out hitDistance))
        {
            Vector3 targetpoint = ray.GetPoint(hitDistance);
            Quaternion targetrotation = Quaternion.LookRotation(targetpoint-transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, rotateSpeed * Time.deltaTime);
        }
    }

    void Update()
    {
        LookAtMouse();
    }
}
