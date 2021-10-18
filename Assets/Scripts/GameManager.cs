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
    [SerializeField] private GameObject GameOverrSound;
    public void GameIsOver()
    {
        Instantiate(GameOverrSound, transform.position, Quaternion.identity);
        if (Logs.HighScore < scoreManager.GetScore())
        {
            Logs.HighScore = scoreManager.GetScore();
            HighScore.text = Logs.HighScore.ToString();
        }
        Score.text = scoreManager.GetScore().ToString();
        scoreManager.Stop();
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
