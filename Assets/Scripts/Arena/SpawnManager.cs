using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnLocation1;
    public GameObject spawnLocation2;
    public GameObject spawnLocation3;
    public GameObject spawnLocation4;
    public GameObject spawnLocation5;
    public GameObject spawnLocation6;
    public GameObject spawnLocation7;
    public GameObject suitEnemy;
    public GameObject skeletonEnemy;
    public float spawnInterval;

    private bool isSpawning = false;
    private int randomPos;
    private int randomEnem;
    private GameObject spawnPosition;
    private GameObject enemy;
    private List<GameObject> spawnLocations = new List<GameObject>();
    private List<GameObject> enemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        spawnLocations.Add(spawnLocation1);
        spawnLocations.Add(spawnLocation2);
        spawnLocations.Add(spawnLocation3);
        spawnLocations.Add(spawnLocation4);
        spawnLocations.Add(spawnLocation5);
        spawnLocations.Add(spawnLocation6);
        spawnLocations.Add(spawnLocation7);

        enemies.Add(suitEnemy);
        enemies.Add(skeletonEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isSpawning)
        {
            StartCoroutine(SpawnEnemy());
        }
    }

    public IEnumerator SpawnEnemy()
    {
        isSpawning = true;
        randomPos = Random.Range(0, 7);
        randomEnem = Random.Range(0, 2);

        spawnPosition = spawnLocations[randomPos];
        enemy = enemies[randomEnem];
        Instantiate(enemy, spawnPosition.transform);

        yield return new WaitForSeconds(spawnInterval);
        isSpawning = false;

    }
}
