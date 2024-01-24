using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrops : MonoBehaviour
{
    [SerializeField] Rain baseRain;
    public Rain rainProperties { get; private set; }
    public List<Rain> rainModifiers = new List<Rain>();

    private void Awake()
    {
        UpdateRainProperty();
        
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
}
