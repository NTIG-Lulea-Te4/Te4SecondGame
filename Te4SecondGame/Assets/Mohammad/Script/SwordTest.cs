using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTest : MonoBehaviour
{
    void Weapon()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Rotate(4, 0, 0, Space.Self);
            transform.Rotate(new Vector3(5, 0, 0));
        }
    }
    void Update()
    {
        Weapon();
        
    }
}
