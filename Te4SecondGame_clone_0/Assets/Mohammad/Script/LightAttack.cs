using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttack : MonoBehaviour
{
    public GameObject target;
    public float speed = 5f;

    void Weapon()
    {
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(target.transform.position, Vector3.right, speed);

        }
    }
    void Update()
    {
        Weapon();
    }
}