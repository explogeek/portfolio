using UnityEngine;

public class HighscoreResetter : MonoBehaviour
{
    public void Reset()
    {
        HighscoreManager.instance.Reset();
        FindObjectOfType<HighscoreListFiller>().Clear();
    }
}
