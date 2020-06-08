using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public PointManager pointManager;
    public Transform gun;
    public string gunName;
    public GameObject paint;
    public Camera fpsCam;

    public int bossShots;
    private bool isShooting = false;

    void Start()
    {
        gunName = gun.gameObject.name;

        bossShots = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();

<<<<<<< HEAD
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && !isShooting)
            {
              
            if (!(hit.transform.GetType() == typeof(Canvas)))
            {
                if (Input.GetMouseButtonDown(0))
                {

                    if (hit.transform.name == "Skeleton" && gunName == "Rainbow Gun")
=======
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Debug.Log(hit.transform.name);

                if (Input.GetMouseButtonDown(0))
                {

                    if (hit.transform.name == "RainbowEnemie" && gunName =="RainbowGun")
>>>>>>> parent of f3f2fbf... Enemies and weapons working
                    {
                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        
                        if (targetEnemie.isActiveAndEnabled)
                        {
                            targetEnemie.addScoreObject();
                            pointManager.getPoint();
                        }

                    }

<<<<<<< HEAD
                    if (hit.transform.name == "MustacheEnemieSuit" && gunName == "Mustache Gun")
                    {

                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        
                        if (targetEnemie.isActiveAndEnabled)
                        {
                            targetEnemie.addScoreObject();
                            pointManager.getPoint();
                        }
                    }
=======
                     if (hit.transform.name == "MustacheEnemie" && gunName == "MustacheGun")
                    {
                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        targetEnemie.addScoreObject();
                        pointManager.getPoint();
                }
>>>>>>> parent of f3f2fbf... Enemies and weapons working

                    if (hit.transform.name == "GorillaBoss")
                    {
                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();

                        if (targetEnemie.isActiveAndEnabled)
                        {
                            bossShots += 1;

                            if(bossShots == 10)
                            {
                                targetEnemie.addScoreObject();
                                pointManager.getPoint();
                            }
                            
                        }

                    }

                    else
                    {
                        if (hit.transform.name == "Wall")
                        {
                            Instantiate(paint, hit.point, Quaternion.identity);
                            paint.transform.LookAt(hit.point + hit.normal);

                        }
                    }
                    Debug.Log("Hit nothing");

                }
<<<<<<< HEAD
=======
            
>>>>>>> parent of f3f2fbf... Enemies and weapons working
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
