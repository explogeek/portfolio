using System;
using UnityEngine;

public abstract class ScoreManager : MonoBehaviour
{
    [SerializeField]
    protected IntVariable currentScore = null;

    public static Action newHighscore = delegate { };
    public static Action scoreIncreased = delegate { };
    public static string GameName { get; protected set; }

    protected int highscore;

    protected virtual void Start()
    {
        highscore = HighscoreManager.instance.GetHighscore(GameName);
        currentScore.value = 0;
    }

    protected virtual void IncreaseScore()
    {
        currentScore.value += 1;
        scoreIncreased();
    }

    public virtual void UpdateHighscore()
    {
        if (currentScore.value > highscore)
        {
            highscore = currentScore.value;
            HighscoreManager.instance.AddHighscore(GameName, highscore);
            newHighscore();
        }
    }
}
