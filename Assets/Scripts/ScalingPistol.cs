using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingPistol : MonoBehaviour
{

    public GameObject parent;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - parent.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = parent.transform.position + offset;
    }
}
