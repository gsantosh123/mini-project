using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObst : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    private void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("Spawn", randomWait);
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
         //Spawn.GetComponent<Spawn>()Spawn = this;
    }

}
