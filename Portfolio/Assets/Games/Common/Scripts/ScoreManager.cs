using System;
using UnityEngine;

public abstract class ScoreManager : MonoBehaviour
{
    [SerializeField]
    protected IntVariable currentScore = null;

    public static Action newHighscore = delegate { };

    protected int highscore;
    protected string gameName;

    protected virtual void Start()
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
            newHighscore();
        }
    }
}
