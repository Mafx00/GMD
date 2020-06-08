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
<<<<<<< HEAD
        mainLights = lights.GetComponent<ParticleSystem>().main;
=======
    mainLights = lights.GetComponent<ParticleSystem>().main;

>>>>>>> parent of f3f2fbf... Enemies and weapons working
    }


    public void addScoreObject()
    {
        scoreObject.SetActive(true);
        scoreObject2.SetActive(true);
        removeWhenScore.SetActive(false);
<<<<<<< HEAD

        if (transform.name != "GorillaBoss")
        {
            Debug.Log(transform.name);

            this.gameObject.GetComponent<Animator>().SetFloat("Blend", 0);
            this.gameObject.GetComponent<EnemieMovement>().enabled = false;
        }

=======
        scoreObject.GetComponent<EnemieShoot>().enabled = false;
        this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
>>>>>>> parent of f3f2fbf... Enemies and weapons working
        mainLights.startColor = Color.green;
        this.enabled = false;

    }
}
