using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//use updateScore to set highscore
//use GetScore to retreive highscore

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int highScore = 0;

    private void Start ()
    {
        AddScore(0);
    }

    public void AddScore(int toAdd) {
        highScore += toAdd;
        scoreText.text = highScore.ToString();
    }
    public void UpdateScore(int newScore)
    {
        highScore = Mathf.Max(highScore, newScore);
    }

    public int GetScore()
    {
        return highScore;
    }

    public void WipeScore()
    {
        highScore= 0;
    }

}
