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
            Score++;
            UI.SetScore(Score);
        }
    }
    public int GetScore()
    {
        return Score;
    }
    public void Stop()
    {
        this.gameObject.SetActive(false);
    }
}
