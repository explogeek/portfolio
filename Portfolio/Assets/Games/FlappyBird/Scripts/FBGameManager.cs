using UnityEngine;
using UnityEngine.Events;

public class FBGameManager : MonoBehaviour
{
    public UnityEvent gameOverEvent;

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
        gameOverEvent.Invoke();
    }

    private void IncreaseScore()
    {
        Debug.Log("Increase score");
    }
}
