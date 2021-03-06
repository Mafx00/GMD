﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieShoot : MonoBehaviour
{

    public GameObject target;
    public GameObject bullet;
    public float speed;

    private Rigidbody bulletRB;
    private Vector3 targetPosition;
    private Vector3 distance;
    private bool isShooting;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        isShooting = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPosition = target.transform.position;
        distance = targetPosition - transform.position;

       if(distance.magnitude < 10 && distance.magnitude > 2 && isShooting)
        {
            StartCoroutine(Shoot());
        }

    }

    IEnumerator Shoot()
    {
       bulletRB = Instantiate(bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        Vector3 direction = ( target.transform.position - transform.position).normalized;
        bulletRB.AddForce(direction * speed);

        isShooting = false;
        yield return new WaitForSeconds(2);
        isShooting = true;
    }
}
