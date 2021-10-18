using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/HighScore", order = 1)]
public class Log : ScriptableObject
{
    public int HighScore = 0;
}
