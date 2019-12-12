using System.Collections.Generic;
using UnityEngine;

public class HighscoreListFiller : MonoBehaviour
{
    [SerializeField]
    private GameObject highscoreRecordPrefab = null;
    [SerializeField]
    private Transform highscoreList = null;

    private void Start()
    {
        foreach (KeyValuePair<string, int> record in HighscoreManager.instance.GamesHighscores)
        {
            var highscoreRecordObj = Instantiate(highscoreRecordPrefab, highscoreList);
            highscoreRecordObj.GetComponent<HighscoreRecordUpdater>().SetData(record.Key, record.Value);
        }
    }
}