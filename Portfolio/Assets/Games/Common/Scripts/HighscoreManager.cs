using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class HighscoreManager : MonoBehaviour
{
    public static HighscoreManager instance;
    public Dictionary<string, int> GamesHighscores { get; private set; }

    private const string playerPrefsKey = "Highscores";

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);

        string highscoresString = PlayerPrefs.GetString("Highscores", "");
        Debug.Log("Loaded highscores: " + highscoresString);
        if (highscoresString == "")
        {
            InitHighscores();
            return;
        }
        try
        {
            GamesHighscores = JsonConvert.DeserializeObject<Dictionary<string, int>>(highscoresString);
            if (GamesHighscores == null)
                InitHighscores();
        }
        catch (JsonException e)
        {
            Debug.Log("Could not deserialize highscores: " + e.Message);
            InitHighscores();
        }
    }

    private void InitHighscores()
    {
        GamesHighscores = new Dictionary<string, int>();
    }

    public void AddHighscore(string gameName, int highscore)
    {
        GamesHighscores[gameName] = highscore;
    }

    public void SaveHighscores()
    {
        try
        {
            string highscoresString = JsonConvert.SerializeObject(GamesHighscores);
            PlayerPrefs.SetString(playerPrefsKey, highscoresString);
        }
        catch (JsonException e)
        {
            Debug.Log("Could not serialize highscores: " + e.Message);
        }
    }

    public int GetHighscore(string gameName)
    {
        if (GamesHighscores.ContainsKey(gameName))
            return GamesHighscores[gameName];
        return 0;
    }

    private void OnApplicationQuit()
    {
        SaveHighscores();
    }
}
