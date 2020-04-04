using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject mustacheGun;
    public GameObject rainbowGun;

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
            mustacheGun.SetActive(false);
            rainbowGun.SetActive(true);
            mustacheGunScript.enabled = false;
            rainbowGunScript.enabled = true;
            pickedUpRainbow.Play();
        }

        if (other.gameObject.CompareTag("MustacheGun"))
        {
            mustacheGun.SetActive(true);
            rainbowGun.SetActive(false);
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
