using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private Log Logs;
    [SerializeField] private Text Score;
    [SerializeField] private Text HighScore;

    public void GameIsOver()
    {
        if (Logs.HighScore < scoreManager.GetScore())
        {
            Logs.HighScore = scoreManager.GetScore();
            HighScore.text = Logs.HighScore.ToString();
        }
        Score.text = scoreManager.GetScore().ToString();
        GameOver.SetActive(true);
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }
}
