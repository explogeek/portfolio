using UnityEngine;
using TMPro;

public class FBHighscoreTextEnabler : MonoBehaviour
{
    [SerializeField]
    private GameObject text = null;

    private void Awake()
    {
        FBScoreManager.newHighscore += EnableText;
    }

    private void OnDestroy()
    {
        FBScoreManager.newHighscore -= EnableText;
    }

    private void EnableText()
    {
        text.SetActive(true);
    }
}
