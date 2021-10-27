using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public float lookRadius = 10f;
    public float radius = 5f;
    GameObject target;
    NavMeshAgent agent;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = transform.DirectionTo(target.position);
        target = GameObject.FindGameObjectWithTag("player");
        float distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance <= lookRadius)
        {
            agent.stoppingDistance = 3f;
            if (distance <= agent.stoppingDistance)
            {

                FaceTarget();
                animator.SetFloat("Speed", agent.velocity.magnitude);

            }
            //animator.SetBool("Attack", false);
         
         
                agent.SetDestination(target.transform.position);
                animator.SetFloat("Speed", agent.velocity.magnitude);

        


            //LookToward(transform.position, distance);
            //Vector3 movement = transform.forward * Time.deltaTime * 1f;
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
        //animator.SetBool("Attack", false);
    }

    void FaceTarget()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        animator.SetFloat("Speed", 0f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
