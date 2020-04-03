using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHolder : MonoBehaviour
{
    public GameObject gun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(pickGunUp());

    }

    public IEnumerator pickGunUp()
    {
        gun.SetActive(false);
        yield return new WaitForSeconds(5);
        gun.SetActive(true);
    }
}
