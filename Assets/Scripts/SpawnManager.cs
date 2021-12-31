using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefabObject;
    private Vector3 randomSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        randomSpawnPoint = new Vector3(Random.Range(-10f, 5f), 7.61f, Random.Range(11.4f, 7f));
        Instantiate(prefabObject, randomSpawnPoint, prefabObject.transform.rotation);
    }
}
