using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScoreType
{
    Normal,
    High,
    Bug,
}

[Serializable]
public class Rain
{
    public ScoreType scoreType;
    [Range(3, 3)] public int score;
    [Range(1f, 20f)] public float speed;

    public DropSO dropSO;
}
