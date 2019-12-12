using UnityEngine;

public abstract class ScoreManager : MonoBehaviour
{
    [SerializeField]
    protected IntVariable currentScore = null;

    protected int highscore;
    protected string gameName;

    protected virtual void Awake()
    {
        highscore = HighscoreManager.instance.GetHighscore(gameName);
        currentScore.value = 0;
    }

    protected virtual void IncreaseScore()
    {
        currentScore.value += 1;
    }

    public virtual void UpdateHighscore()
    {
        if (currentScore.value > highscore)
        {
            highscore = currentScore.value;
            HighscoreManager.instance.AddHighscore(gameName, highscore);
        }
    }
}
