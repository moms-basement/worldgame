using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    [SerializeField] private GameObject meteor;
    [SerializeField] private GameObject parent;
    [SerializeField] private float radius;

    private float nextSpawnTime;

    private float spawnDelay = 6;

    // Update is called once per frame
    void Update()
    { 
        if (ShouldSpawn())
        {
            spawnDelay -= 0.2f;

            if (spawnDelay <= 0.4f)
            {
                spawnDelay = 0.4f;   
            }
            
            Spawn();   
        }       
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
   
        Instantiate(meteor, Random.insideUnitCircle.normalized * radius, Quaternion.identity, parent.transform);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
