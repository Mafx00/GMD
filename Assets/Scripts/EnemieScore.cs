using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieScore : MonoBehaviour
{
    public GameObject scoreObject;

    public ParticleSystem lights;

    public ParticleSystem.MainModule mainLights;

    // Start is called before the first frame update
    void Start()
    {
        scoreObject.GetComponent<GameObject>();
    mainLights = lights.GetComponent<ParticleSystem>().main;

    }


    public void addScoreObject()
    {
        scoreObject.SetActive(true);
        scoreObject.GetComponent<EnemieShoot>().enabled = false;
        scoreObject.GetComponent<EnemieMovement>().enabled = false;
        mainLights.startColor = Color.green;
    }
}
