using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemieBullet : MonoBehaviour
{
    public GameObject healthBar;
    private Slider healthBarComponent;

    public AudioSource hitSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
        healthBar = GameObject.Find("HealthBar");
        healthBarComponent = healthBar.GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            healthBarComponent.value -= 1;
            hitSound.Play();
            Destroy(this.gameObject);
        }
    }
}
