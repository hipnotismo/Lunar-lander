using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    [SerializeField] private float points;
    private float maxPoints;

    [SerializeField] private Text score;
    [SerializeField] private Text highScore;

    public static bool GameIsPause = false;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject WinMenu;
    [SerializeField] private GameObject LoseMenu;


    private void Awake()
    {
        if (GameManager.inst == null)
        {
            maxPoints = 0;
            GameManager.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        score.text = "POINTS: " + points.ToString() ;
        highScore.text = "MAX POINTS: " + maxPoints.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void addPoints(int add)
    {
        points += add;
        score.text = points.ToString() + " POINTS";
        if (maxPoints < points)
        {
            maxPoints = points;
            highScore.text = maxPoints.ToString() + " MAX POINTS";
        }

    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void menuButton()
    {
        SceneManager.LoadScene("Gameplay"); 
        SceneManager.LoadScene("Main");
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;

    }

    public void Win()
    {
        WinMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Lose()
    {
        LoseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void Restart()
    {
       SceneManager.LoadScene("Gameplay");
        PauseMenu.SetActive(false);
        WinMenu.SetActive(false);
        LoseMenu.SetActive(false);

        Time.timeScale = 1f;
        GameIsPause = false;

    }

    public void exitButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
