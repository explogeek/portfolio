using UnityEngine;
using TMPro;

public class HighscoreRecordUpdater : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI gameName = null;
    [SerializeField]
    private TextMeshProUGUI highscore = null;

    public void SetData(string gameName, int highscore)
    {
        this.gameName.text = gameName;
        this.highscore.text = highscore.ToString();
    }
}
