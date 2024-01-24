using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    public static DropManager instance;

    private ObjectPool ObjectPool;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ObjectPool = GetComponent<ObjectPool>();
    }
    public void DropFromSky(Vector3 dropPosition, DropSO dropSO )
    {
        GameObject obj = ObjectPool.SpawnFromPool(dropSO.DropNameTag);
       
        
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3f, 5f);
       
        dropPosition = new Vector3(x, y, 0);

        obj.SetActive(true);
        


        
    }

}
