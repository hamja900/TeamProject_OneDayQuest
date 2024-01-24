using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="DefaultDropData", menuName ="DropObjectSetting/Drop",order =0)]
public class DropSO : ScriptableObject
{
    [Header("PlayInfo")]
    public int score;
    public int point;
    public float speed;
    public LayerMask target;
    public string DropNameTag;
    
}
