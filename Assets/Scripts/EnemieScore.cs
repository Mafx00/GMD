using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemieScore : MonoBehaviour
{
    public GameObject scoreObject;
    public GameObject scoreObject2;
    public GameObject removeWhenScore;

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
        scoreObject2.SetActive(true);
        removeWhenScore.SetActive(false);
        scoreObject.GetComponent<EnemieShoot>().enabled = false;
        this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
        mainLights.startColor = Color.green;
    }
}
