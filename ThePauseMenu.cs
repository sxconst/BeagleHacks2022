using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThePauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject resumeButton;
    public GameObject quitButton;
    public AudioSource audioSource;
    int menu = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SceneManager.GetSceneAt(menu);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Menu.gameIsOver == false)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

       // if (Menu.gameIsOver == true)
        //{
         //   audioSource.Pause();
       // }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        audioSource.Play();
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        audioSource.Pause();
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Score.newScore = 0;
        GameIsPaused = false;
        SceneManager.LoadScene(menu);
    }
}
