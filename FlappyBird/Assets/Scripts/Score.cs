using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : PlayerTrigger
{
    public int amountToGive = 1;

    private void Start()
    {
    }

    public override void OnPlayerEnter(GameObject collision)
    {
        CounterScore counterScore = collision.GetComponent<CounterScore>();
        counterScore.GetScore(amountToGive);
    }
}