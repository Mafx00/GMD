using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemieMovement : MonoBehaviour
{
    public Transform target;

    private NavMeshAgent navMeshAgent;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = target.transform.position;

        if((targetPosition - transform.position).magnitude < 40 )
        {
            navMeshAgent.SetDestination(targetPosition);
        }
    }
}
