using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScore : MonoBehaviour
{
    public int currentScore;
    public Text scoreText;

    public void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    public void GetScore(int scoreAmount)
    {
        currentScore += scoreAmount;
        scoreText.text = currentScore.ToString();
    }
}