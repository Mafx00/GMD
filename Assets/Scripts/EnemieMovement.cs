using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemieMovement : MonoBehaviour
{
    public Transform target;
    public Animator movement;
    public float distance;

    private float isWalking = 1;
    private NavMeshAgent navMeshAgent;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        //.FindGameObjectWithTag("Player").transform;
        navMeshAgent = this.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = target.transform.position;
        Debug.Log(target.name);

        if ((targetPosition - transform.position).magnitude <= distance)
        {
            movement.SetFloat("Blend", 1f);
            navMeshAgent.SetDestination(targetPosition);
        }

        if ((targetPosition - transform.position).magnitude > distance)
        {
            navMeshAgent.SetDestination(transform.position); 
            movement.SetFloat("Blend", 0f);

        }

    }
}
