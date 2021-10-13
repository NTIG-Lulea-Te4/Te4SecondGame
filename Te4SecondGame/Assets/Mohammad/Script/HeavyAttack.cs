using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttack : MonoBehaviour
{
    public GameObject target;
    public float speed = 5f;

    void Weapon()
    {
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(target.transform.position, Vector3.up, speed);

        }
    }
    void Update()
    {
        Weapon();
    }
}