using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerArena : MonoBehaviour
{

    public GameObject mustacheGun;
    public GameObject rainbowGun;

    public ShootArena mustacheGunScript;
    public ShootArena rainbowGunScript;

    public AudioSource pickedUpRainbow;
    public AudioSource pickedUpMustache;
    public AudioSource gotHitsound;

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
            gotHitsound.Play();
        }


    }

}
