using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonkMovement : MonoBehaviour
{
    Animator animate;
    public bool parry;
    public bool attacking;
    public bool attackingH;
    public bool attackingSp;
    public bool attackingSH;
    public bool myAttackFlag;
    public bool secondAttackFlag;
    private float currentTime;
    private float startingTime;
    private float startingSecondTime;
    private float currentSecondTime;


    // Start is called before the first frame update
    void Start()
    {

        startingTime = 0f;
        currentTime = 1.5f;
        currentTime = startingTime;
        startingSecondTime = 0f;
        currentSecondTime = 1.5f;
        currentSecondTime = startingSecondTime;
        animate = GetComponent<Animator>();
        parry = animate.GetBool("parry");
        attacking = animate.GetBool("attacking");
        attackingH = animate.GetBool("attackingH");
        attackingSp = animate.GetBool("attackingSp");
        attackingSH = animate.GetBool("attackingSH");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && attacking == false && myAttackFlag == false)
        {
            animate.SetBool("attacking", true);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0) && myAttackFlag == false)
        {
            animate.SetBool("attacking", false);
            myAttackFlag = true;
        }
        if (myAttackFlag == true)
        {
            currentTime += 1.5f * Time.deltaTime;
            if (currentTime >= 1.5f)
            {
                
                myAttackFlag = false;
                currentTime = 0f;
            }
        }

        if (secondAttackFlag == false && myAttackFlag && Input.GetKeyDown(KeyCode.Mouse0))
        {
            animate.SetBool("attackingSH", true);

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animate.SetBool("attackingSH", false);
            secondAttackFlag = true;
        }
        if (secondAttackFlag == true)
        {
            
            currentSecondTime += 1.5f * Time.deltaTime;
            if (currentSecondTime >= 1.5f)
            {

                secondAttackFlag = false;
                currentSecondTime = 0f;
            }
        }

        if (Input.GetButtonDown("Fire2") && attacking == false)
        {
            animate.SetBool("attackingSp", true);
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            animate.SetBool("attackingSp", false);

        }

        if (Input.GetButtonDown("Fire3") && attacking == false)
        {
            animate.SetBool("attackingH", true);

        }
        else if (Input.GetButtonUp("Fire3"))
        {
            animate.SetBool("attackingH", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && parry == false)
        {
            animate.SetBool("parry", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animate.SetBool("parry", false);
        }
    }
}

