using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public PlayerMovement playerMovement;
    //public GameObject obstacle;
    public GameObject[] obstacles;
    private GameObject inst;
    //private int tally = 0;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timeBetweenSpawns;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float SpawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > SpawnTime && playerMovement.GetDistance() > 5)
        {
            Spawn();
            SpawnTime = Time.time + timeBetweenSpawns;
        }
    }

    void Spawn()
    {
        timeBetweenSpawns = Random.Range(minSpawnTime, maxSpawnTime);
        int randomObject = Random.Range(0, obstacles.Length);
        GameObject newObject = obstacles[randomObject];
        float X = Random.Range(minX, maxX);
        float Y = Random.Range(minY, maxY);
        inst = Instantiate(newObject, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
