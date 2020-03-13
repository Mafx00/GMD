using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemieBullet : MonoBehaviour
{
    public Slider healthBar;
    public GameObject Enemie;

    public AudioSource hitSound;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            healthBar.value -= 1;
            hitSound.Play();
            Destroy(this.gameObject);
        }
    }
}
