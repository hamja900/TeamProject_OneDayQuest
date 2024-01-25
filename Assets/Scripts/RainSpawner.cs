using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] rainPrefabs;

    public float spawnInterval = 0.5f;
    public float initialSpawnDelay = 3f;

    private List<GameObject> rainPool;
    private List<int> availableSpawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        rainPool = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
