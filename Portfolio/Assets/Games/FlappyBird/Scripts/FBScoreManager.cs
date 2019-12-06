using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBScoreManager : MonoBehaviour
{
    [SerializeField]
    private IntVariable currentScore = null;

    private void Awake()
    {
        currentScore.value = 0;
        FBPlayer.OnGatePass += IncreaseScore;
    }

    private void OnDestroy()
    {
        FBPlayer.OnGatePass -= IncreaseScore;
    }

    private void IncreaseScore()
    {
        currentScore.value += 1;
    }
}
