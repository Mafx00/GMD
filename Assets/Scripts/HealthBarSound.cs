using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSound : MonoBehaviour
{
    public Slider healthBar;
    public AudioSource lostHealthSound;
    public AudioSource gainedHealthSound;

    private float health;
    private float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = healthBar.value;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = healthBar.value;
        if(currentHealth < health)
        {
            lostHealthSound.Play();
            health = currentHealth;
        }

        if(currentHealth > health)
        {
            gainedHealthSound.Play();
            health = currentHealth;
        }
    }
}
