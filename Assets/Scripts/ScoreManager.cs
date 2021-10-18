using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int Score;
    [SerializeField] private UIManager UI;
    void Start()
    {
        Score = 0;
        UI.SetScore(Score);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("h");
            Score++;
            UI.SetScore(Score);
        }
    }
}
