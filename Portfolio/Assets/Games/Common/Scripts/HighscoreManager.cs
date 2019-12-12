using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class HighscoreManager : MonoBehaviour
{
    public static HighscoreManager instance;

    private Dictionary<string, int> gamesHighscores;
    public Dictionary<string, int> GamesHighscores { get; }
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
            gamesHighscores = JsonConvert.DeserializeObject<Dictionary<string, int>>(highscoresString);
        }
        catch (JsonSerializationException e)
        {
            Debug.Log("Could not deserialize highscores: " + e.Message);
            InitHighscores();
        }
    }

    private void InitHighscores()
    {
        gamesHighscores = new Dictionary<string, int>();
    }

    public void AddHighscore(string gameName, int highscore)
    {
        gamesHighscores[gameName] = highscore;
    }

    public void SaveHighscores()
    {
        try
        {
            string highscoresString = JsonConvert.SerializeObject(gamesHighscores);
            PlayerPrefs.SetString(playerPrefsKey, highscoresString);
        }
        catch (JsonSerializationException e)
        {
            Debug.Log("Could not serialize highscores: " + e.Message);
        }
    }

    public int GetHighscore(string gameName)
    {
        if (gamesHighscores.ContainsKey(gameName))
            return gamesHighscores[gameName];
        return 0;
    }

    private void OnApplicationQuit()
    {
        SaveHighscores();
    }
}
