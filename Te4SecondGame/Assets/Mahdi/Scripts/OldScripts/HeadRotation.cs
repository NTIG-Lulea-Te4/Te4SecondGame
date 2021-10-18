using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    public static float amountOfRotation;


    // Start is called before the first frame update
    void Start()
    {
        amountOfRotation = 0.4f;
        NoseRotation.SetValue(amountOfRotation);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, amountOfRotation, 0);
    }
}
