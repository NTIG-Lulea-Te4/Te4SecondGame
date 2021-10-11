using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("MovableCube");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            cube.transform.position = new Vector3(-1, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(1, 0, 0);

        }
    }
}
