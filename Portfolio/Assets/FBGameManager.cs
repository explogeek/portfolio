using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBGameManager : MonoBehaviour
{
    private void Awake()
    {
        FBPlayer.OnHit += GameOver;
        FBPlayer.OnGatePass += IncreaseScore;
    }


    private void OnDestroy()
    {
        FBPlayer.OnHit -= GameOver;
        FBPlayer.OnGatePass -= IncreaseScore;
    }

    private void GameOver()
    {
        Debug.Log("Game over!");
        FBMover.Stop();
    }

    private void IncreaseScore()
    {
        Debug.Log("Increase score");
    }
}
