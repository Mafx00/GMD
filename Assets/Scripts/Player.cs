using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Renderer mustacheGun;
    public Renderer rainbowGun;

    public Shoot mustacheGunScript;
    public Shoot rainbowGunScript;

    public AudioSource pickedUpRainbow;
    public AudioSource pickedUpMustache;

    public Slider slider;

    public int speed;
   
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RainbowGun"))
        {
            mustacheGun.enabled = false;
            rainbowGun.enabled = true;
            mustacheGunScript.enabled = false;
            rainbowGunScript.enabled = true;
            pickedUpRainbow.Play();
        }

        if (other.gameObject.CompareTag("MustacheGun"))
        {
            mustacheGun.enabled = true;
            rainbowGun.enabled = false;
            mustacheGunScript.enabled = true;
            rainbowGunScript.enabled = false;
            pickedUpMustache.Play();
        }

        if (other.gameObject.CompareTag("Enemie"))
        {
            slider.value -= 1;
        }

        if (other.gameObject.CompareTag("EnemieButton"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Health"))
        {
            slider.value = 5;
        }
    }

}
