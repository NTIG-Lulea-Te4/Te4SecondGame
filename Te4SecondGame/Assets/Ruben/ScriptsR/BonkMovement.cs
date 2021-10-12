using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonkMovement : MonoBehaviour
{

    Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animate.SetBool("attacking", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animate.SetBool("attacking", false);
        }
    }
}
