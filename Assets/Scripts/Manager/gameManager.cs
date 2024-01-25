using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject rain;
    public RainDrops raindrops;
    public DropSO dropSO;
    public GameObject rainSpawnPosition;

    void Awake()
    {
        I = this;
        raindrops = rain.GetComponent<RainDrops>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartDrop", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDrop()

    {
        float x = Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(rainSpawnPosition.transform.position, dropSO);
    }
}

