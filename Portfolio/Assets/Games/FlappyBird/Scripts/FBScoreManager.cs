using UnityEngine;

public class FBScoreManager : ScoreManager
{
    protected override void Awake()
    {
        gameName = "Flappy Bird";
        FBPlayer.OnGatePass += IncreaseScore;
        base.Awake();
    }

    private void OnDestroy()
    {
        FBPlayer.OnGatePass -= IncreaseScore;
    }
}
