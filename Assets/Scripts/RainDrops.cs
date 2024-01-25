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
    public GameObject prefab;
    public gameManager gameManager;

    private void Awake()
    {
        UpdateRainProperty();
        
    }

    private void Start()
    {
        float x = UnityEngine.Random.Range(-2.7f, 2.7f);
        transform.position = new Vector3(x, 4, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {           
            prefab.SetActive(false);
        }
        else if (collision.gameObject.tag == "Player")
        {
            gameManager.I.GrowthCarrot();
            prefab.SetActive(false);
        }
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
