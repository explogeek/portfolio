public class FBScoreManager : ScoreManager
{
    private void Awake()
    {
        GameName = "Flappy Bird";
    }

    protected override void Start()
    {
        FBPlayer.OnGatePass += IncreaseScore;
        base.Start();
    }

    private void OnDestroy()
    {
        FBPlayer.OnGatePass -= IncreaseScore;
    }
}
