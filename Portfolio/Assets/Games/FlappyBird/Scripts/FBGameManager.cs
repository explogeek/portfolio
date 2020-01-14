using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FBGameManager : MonoBehaviour
{
    public UnityEvent gameOverEvent;
    public UnityEvent gameStartEvent;

    private void Awake()
    {
        FBPlayer.OnHit += GameOver;
        gameStartEvent.AddListener(() => FBMover.Start());
        gameStartEvent.AddListener(() => TextureOffsetMover.Start());
        gameStartEvent.Invoke();
    }

    private void OnDestroy()
    {
        FBPlayer.OnHit -= GameOver;
    }

    private void GameOver()
    {
        FBMover.Stop();
        gameOverEvent.Invoke();
    }

    public void Quit()
    {
        FindObjectOfType<FBScoreManager>().UpdateHighscore();
        HighscoreManager.instance.SaveHighscores();
        SceneManager.LoadScene(0);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
