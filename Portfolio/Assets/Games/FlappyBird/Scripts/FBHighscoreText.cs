using UnityEngine;
using TMPro;

public class FBHighscoreText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text = null;
    [SerializeField]
    private TMP_ColorGradient regularColorGradient = null;
    [SerializeField]
    private TMP_ColorGradient winColorGradient = null;

    private void Start()
    {
        text.colorGradientPreset = regularColorGradient;
        FBScoreManager.newHighscore += SetHighscore;
        FBScoreManager.scoreIncreased += ShowHighscore;
        ShowHighscore();
    }

    private void OnDestroy()
    {
        try
        {
            FBScoreManager.newHighscore -= SetHighscore;
            FBScoreManager.scoreIncreased -= ShowHighscore;
        }
        finally { }
    }

    private void SetHighscore()
    {
        FBScoreManager.scoreIncreased -= ShowHighscore;
        text.text = "NEW HIGHSCORE!";
        text.colorGradientPreset = winColorGradient;
    }

    private void ShowHighscore()
    {
        text.text = "BEST: " + HighscoreManager.instance.GetHighscore(FBScoreManager.GameName);
        text.colorGradientPreset = regularColorGradient;
    }
}
