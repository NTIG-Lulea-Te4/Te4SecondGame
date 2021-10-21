using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public float lookRadius = 10f;
    Transform target;
    NavMeshAgent agent;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = transform.DirectionTo(target.position);
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookRadius)
        {
            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
                
            }
            agent.SetDestination(target.position);
            animator.SetFloat("Speed", agent.velocity.magnitude);
            //LookToward(transform.position, distance);
            //Vector3 movement = transform.forward * Time.deltaTime * 1f;
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
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
