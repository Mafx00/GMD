using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotMovement : MonoBehaviour
{
    public Animator animator;
    public GameObject target;
    public float distance;

    private NavMeshAgent navMeshAgent;
    private bool iswalking = false;
    private Vector3 targetDistance;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        targetDistance = target.transform.position - transform.position;

        if(targetDistance.magnitude < distance && iswalking == false)
        {
            animator.SetFloat("Blend", 1);
            iswalking = true;
        }

        if (targetDistance.magnitude < distance && iswalking == true)
        {
            navMeshAgent.SetDestination(target.transform.position);
            animator.enabled = true;
        }

        if (targetDistance.magnitude >= distance && iswalking == true)
        {
            navMeshAgent.SetDestination(transform.position);
            animator.SetFloat("Blend", 0);
            iswalking = false;
        }

    }
}
