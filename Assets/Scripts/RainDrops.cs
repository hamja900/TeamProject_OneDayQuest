using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class RainDrops : MonoBehaviour
{
    [SerializeField] Rain baseRain;
    public DropSO[] dropSO;
    public Rain rainProperties { get; private set; }
    public List<Rain> rainModifiers = new List<Rain>();
    public GameObject prefab;

    private WaterGauge _waterGauge;


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
        if (collision.gameObject.tag == "Player")
        {
            _waterGauge = collision.GetComponent<WaterGauge>();
            if (gameObject.tag == "NormalRain")
            {
                gameManager.I.GetPoint(0);
                gameManager.I.GrowthCarrot();
                prefab.SetActive(false);
            }
            else if ( gameObject.tag == "HighRain")
            {
                gameManager.I.GetPoint(1);
                gameManager.I.GrowthCarrot();
                prefab.SetActive(false);
            }
            else if (gameObject.tag == "Bug")
            {
                //gameManager.I.GetPoint(2);
                //gameManager.I.GrowthCarrot();
                gameManager.I.BugCount();
                prefab.SetActive(false);
                AudioManager.instance.SoundPlayOneShot(AudioManager.instance.fail);
            }
            
            _waterGauge.ChargeGauge(gameManager.I.current);
           
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
