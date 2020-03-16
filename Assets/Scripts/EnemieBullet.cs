using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemieBullet : MonoBehaviour
{
    public Slider healthBar;
    private Slider healthBarComponent;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
        healthBar = (Slider) Canvas.FindObjectOfType(typeof(Slider));
        healthBarComponent = healthBar.GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healthBarComponent.value -= 1;
            Destroy(this.gameObject);
        }
    }
}