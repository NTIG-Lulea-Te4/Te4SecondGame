//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class NewAI : MonoBehaviour
//{
//    public NavMeshAgent agent;
//    public Transform player;
//    public LayerMask whatIsGround, whatIsPlayer;

//    //p
//    public Vector3 walkPoint;
//    bool walkPointSet;
//    public float walkPointRange;
//    //A

//    //States
//    public float sightRange;
//    public bool playerInSightRange;

//    private void Awake()
//    {
//        player = GameObject.Find("player").transform;
//        agent = GetComponent<NavMeshAgent>();
//    }
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
//        if (!playerInSightRange)
//        {
//            Patroling();
//        }
//        if (playerInSightRange)
//        {
//            ChasePlayer();
//        }
//    }
//    private void Patroling()
//    {
//        if (!walkPointSet)
//        {
//            SearchWalkPoint();
//        }
//        if (walkPointSet)
//        {
//            agent.SetDestination(walkPoint);
//        }
//        Vector3 distanceToWalkPoint = transform.position - walkPoint;

//        if(distanceToWalkPoint.magnitude < 1f)
//        {
//            walkPointSet = false;
//        }
//    }
//    private void SearchWalkPoint()
//    {
//        float randomZ = Random.Range(-walkPointRange, walkPointRange);
//        float randomX = Random.Range(-walkPointRange, walkPointRange);

//        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
//        if(Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
//        {
//            walkPointSet = true;
//        }
//    }
//    private void ChasePlayer()
//    {
//        agent.SetDestination(player.position);
//    }
//}
