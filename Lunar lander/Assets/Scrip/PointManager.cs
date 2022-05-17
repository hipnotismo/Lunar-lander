using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public static PointManager inst;
    [SerializeField] private float points;
    private float maxPoints;

    public Text score;
    public Text highScore;

    private void Awake()
    {
        if (PointManager.inst == null)
        {
            maxPoints = 0;
            PointManager.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        score.text = points.ToString() + " POINTS";
        highScore.text = maxPoints.ToString() + " MAX POINTS";
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
