using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    private void Update()
    {
        
    }

    public void SpawnObject()
    {
        
        Instantiate(spawnee, transform.position, transform.rotation);
        
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
