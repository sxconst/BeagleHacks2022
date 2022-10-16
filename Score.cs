using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int newScore = 0;
    public static int desiredScore = 1;
    public static float currentTime = 0f;
    public static float startingTime = 32f;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = newScore.ToString();
        if (ThePauseMenu.GameIsPaused == false && Menu.gameIsOver == false)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
            Menu.gameIsOver = true;
        }
    }
}
