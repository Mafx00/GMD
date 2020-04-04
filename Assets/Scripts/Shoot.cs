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
    // Start is called before the first frame update
    void Start()
    {
        gunName = gun.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Debug.Log(hit.transform.name);

                if (Input.GetMouseButtonDown(0))
                {

                    if (hit.transform.name == "RainbowEnemie" && gunName =="RainbowGun")
                    {
                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        targetEnemie.addScoreObject();
                        pointManager.getPoint();

                    }

                     if (hit.transform.name == "MustacheEnemie" && gunName == "MustacheGun")
                    {
                        EnemieScore targetEnemie = hit.transform.gameObject.GetComponent<EnemieScore>();
                        targetEnemie.addScoreObject();
                        pointManager.getPoint();
                }

                else
                {
                    Instantiate(paint, hit.point, Quaternion.identity);
                   paint.transform.LookAt(hit.point + hit.normal);
                }

                }
            
            }
                Vector3 direction = hit.point - gun.position;
                gun.rotation = Quaternion.LookRotation(direction);
        }
    
}
