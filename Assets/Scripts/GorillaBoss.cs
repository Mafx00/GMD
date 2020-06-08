using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GorillaBoss : MonoBehaviour
{
    public Animator animator;
    public GameObject target;
    public float distance;
    public GameObject Shoot;
    
    private EnemieShoot shoot;
    private NavMeshAgent navMeshAgent;
    private bool iswalking = false;
    private bool isThrowing = false;
    private Vector3 targetDistance;

    void Start()
    {
        navMeshAgent = this.gameObject.GetComponent<NavMeshAgent>();
        EnemieShoot shoot = Shoot.GetComponent<EnemieShoot>();
        shoot.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        targetDistance = target.transform.position - transform.position;

        if (targetDistance.magnitude < distance && iswalking == false && isThrowing == false)
        {
            StartCoroutine(ShootBanana());

            Debug.Log(animator.GetBool("isThrowing"));

        }

       else if (targetDistance.magnitude < distance && iswalking == true && isThrowing == true)
        {
            StartCoroutine(FollowPlayer());

            Debug.Log(animator.GetBool("isWalking" + 2));
        }


        else if (targetDistance.magnitude >= distance && iswalking == true || isThrowing == true)
        {
            navMeshAgent.SetDestination(transform.position);
            animator.SetBool("isWalking", false);
            animator.SetBool("isThrowing", false);
            iswalking = false;
            isThrowing = false;
            Shoot.GetComponent<EnemieShoot>().enabled = false;
        }

    }

    public IEnumerator ShootBanana()
    {
        Shoot.GetComponent<EnemieShoot>().enabled = true;
        navMeshAgent.SetDestination(transform.position);
        isThrowing = true;
        iswalking = false;
        animator.SetBool("isThrowing", true);
        animator.SetBool("isWalking", false);

        yield return new WaitForSeconds(2);
        Shoot.GetComponent<EnemieShoot>().enabled = false;
        isThrowing = true;
        iswalking = true;

    }

    public IEnumerator FollowPlayer()
    {
        navMeshAgent.SetDestination(target.transform.position);
        isThrowing = false;
        animator.SetBool("isWalking", true);
        animator.SetBool("isThrowing", false);
        yield return new WaitForSeconds(3);
        iswalking = false;

    }
}
