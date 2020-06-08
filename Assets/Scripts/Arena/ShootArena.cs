using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArena: MonoBehaviour
{
    public PointManagerArena pointManager;
    public Transform gun;
    public string gunName;
    public Camera fpsCam;

    private bool isShooting = false;

    void Start()
    {
        gunName = gun.gameObject.name;

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && !isShooting)
            {
              
            if (!(hit.transform.GetType() == typeof(Canvas)))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log(hit.transform.name);

                    if (hit.transform.name == "ASkeletonEnemie(Clone)" && gunName == "Rainbow Gun")
                    {
                        Debug.Log("hit skeleton");

                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        
                        if (targetEnemie.isActiveAndEnabled)
                        {
                            targetEnemie.addScoreObject();
                            pointManager.getPoint();
                            Destroy(hit.transform.gameObject, 3f);
                        }

                    }

                    if (hit.transform.name == "AMustacheEnemieSuit(Clone)" && gunName == "Mustache Gun")
                    {
                        Debug.Log("hit suitMan");

                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        
                        if (targetEnemie.isActiveAndEnabled)
                        {
                            targetEnemie.addScoreObject();
                            pointManager.getPoint();
                            Destroy(hit.transform.gameObject, 3f);
                        }
                    }

                }
            }

            Vector3 direction = hit.point - gun.position;
            gun.rotation = Quaternion.LookRotation(-direction);
        }
        }
    
    public IEnumerator ShootingTimer()
    {
        isShooting = true;
        yield return new WaitForSeconds(2);
        isShooting = false;
    }
}
