using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void InitialPlayGame()
    {
        Menu.gameIsOver = false;
        ThePauseMenu.GameIsPaused = false;
        Time.timeScale = 1f;
        Score.newScore = 0;
        SceneManager.LoadScene(1);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
