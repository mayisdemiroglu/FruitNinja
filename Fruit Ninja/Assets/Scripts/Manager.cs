using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    public GameObject panel;

    private void Start()
    {
        
    }
    void Update()
    {
        GameScore();
    }

    private void GameScore()
    {
        scoreText.text = score.ToString();
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1.0f;
    }

    /*public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/

    public void GameOver()
    {
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

}
