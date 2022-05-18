using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    [SerializeField] private float points;
    private float maxPoints;

    [SerializeField] private Text score;
    [SerializeField] private Text highScore;

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
}
