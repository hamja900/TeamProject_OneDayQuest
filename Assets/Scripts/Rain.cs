using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScoreType
{
    Normal,
    Gold,
    Bug,
}
public class Rain
{
    public ScoreType scoreType;
    [Range(-30, 50)] public int score;
    [Range(1f, 20f)] public float speed;

    DropSO dropSO;
}
