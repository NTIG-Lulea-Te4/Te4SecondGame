using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoseRotation : MonoBehaviour
{
    public GameObject myHead;

    static float amountOfRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static void SetValue(float rotate)
    {
        amountOfRotation = rotate;
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(myHead.transform.position, new Vector3(0, 1, 0), amountOfRotation);
        transform.Rotate(amountOfRotation, 0, 0);
    }
}
