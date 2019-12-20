public class FBScoreManager : ScoreManager
{
    protected override void Start()
    {
        gameName = "Flappy Bird";
        FBPlayer.OnGatePass += IncreaseScore;
        base.Start();
    }

    private void OnDestroy()
    {
        FBPlayer.OnGatePass -= IncreaseScore;
    }
}
