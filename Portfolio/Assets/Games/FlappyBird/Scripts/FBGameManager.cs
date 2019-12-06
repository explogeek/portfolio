using UnityEngine;
using UnityEngine.Events;

public class FBGameManager : MonoBehaviour
{
    public UnityEvent gameOverEvent;
    public UnityEvent gameStartEvent;

    private void Awake()
    {
        FBPlayer.OnHit += GameOver;
        gameStartEvent.AddListener(() => FBMover.Start());
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
}
