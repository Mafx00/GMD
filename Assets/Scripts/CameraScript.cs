using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float speedH;
    public float speedV;

    private float horizontal = 0.0f;
    private float vertical = 0.0f;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
<<<<<<< HEAD

        horizontal += speedH * Input.GetAxis("Mouse X");
        vertical -= speedV * Input.GetAxis("Mouse Y");
        float moveHorizontal = Input.GetAxis("Horizontal");

       transform.eulerAngles = new Vector3(vertical, horizontal - 90f, 0f);
       
        //this.gameObject.transform.Rotate(Vector3.up, 90f * Time.deltaTime * moveHorizontal);

        /* 
      if(Input.GetKey(KeyCode.Q))
       {
           this.gameObject.transform.Rotate(Vector3.down);
       }

       if (Input.GetKey(KeyCode.E))
       {
           this.gameObject.transform.Rotate(Vector3.right);
       }
       */
=======
>>>>>>> parent of f3f2fbf... Enemies and weapons working
    }
}
