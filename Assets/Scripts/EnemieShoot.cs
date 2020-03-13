using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieShoot : MonoBehaviour
{

    public GameObject Target;
    private Vector3 targetPosition;
    private Vector3 offset;

    private bool isShooting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      targetPosition =  Target.transform.position;
        offset = targetPosition - transform.position;

        if(offset.magnitude < 5)
        {
            isShooting = true;
        }

        if (offset.magnitude > 5)
        {
            isShooting = true;
        }
    }
}
