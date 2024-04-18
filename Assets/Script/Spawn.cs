using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    //public float spawnRate;
    public float timeForSpawn;
    private float spawnTime;
    private float timeInterval = 1.0f;
    private float nextIncreaseTime = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime){
            SpawnObject();
            spawnTime = Time.time + timeForSpawn;
        }
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
