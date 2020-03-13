using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController player;

    public int speed;
    public Vector3 moveDirection;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        moveDirection = transform.right * moveHorizontal + transform.forward * moveVertical;

        player.Move(moveDirection * speed * Time.deltaTime);

        velocity.y += -0.1f * Time.deltaTime;
        player.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && player.transform.position.y < 2)
        {
            player.Move(Vector3.up * 30 * speed * Time.deltaTime);

            // player.transform.position += Vector3.up * 7;
        }
    }
}
