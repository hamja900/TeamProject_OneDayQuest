using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrops : MonoBehaviour
{
    [SerializeField] Rain baseRain;
    public DropSO dropSO;
    public Rain rainProperties { get; private set; }
    public List<Rain> rainModifiers = new List<Rain>();



    private void Awake()
    {
        UpdateRainProperty();
        
    }

    private void Start()
    {

    }

    private void UpdateRainProperty()
    {
        DropSO dropSO = null;
        if(baseRain.dropSO != null)
        {
            dropSO = Instantiate(baseRain.dropSO);
        }

        rainProperties = new Rain { dropSO = dropSO };
        rainProperties.scoreType =baseRain.scoreType;
        rainProperties.score = baseRain.score;
        rainProperties.speed = baseRain.speed;

    }
    public void StartDrop()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
        DropManager.instance.DropFromSky(transform.position, dropSO);
    }
}
