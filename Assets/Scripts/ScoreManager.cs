using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ScoreText.text = "POINTS: " + score.ToString();
    }

    public void Addpoints()
    {
        score += 5;
        ScoreText.text = "POINTS: " + score.ToString();
    }

}
