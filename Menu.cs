using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public static bool gameIsOver = false;
    public GameObject gameOverScreen;
    public GameObject HUD;
    private int menu = 0;
    [SerializeField] TextMeshProUGUI finalScore;

    public void PlayGame()
    {
        Score.currentTime = Score.startingTime;
        gameIsOver = false;
        SceneManager.LoadScene(1);
        gameOverScreen.SetActive(false);
        ThePauseMenu.GameIsPaused = false;
        Time.timeScale = 1f;
        Score.newScore = 0;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        HUD.SetActive(false);
        Time.timeScale = 0f;
        finalScore.text = "Beagles Rescued: " + Score.newScore.ToString();
    }

    public void Leave()
    {
        Time.timeScale = 1f;
        Score.newScore = 0;
        ThePauseMenu.GameIsPaused = false;
        gameIsOver = false;
        SceneManager.LoadScene(menu);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsOver == true)
        {
            GameOver();
        }
    }
}
