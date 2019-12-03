using UnityEngine;

public class UrlOpener : MonoBehaviour
{
    [SerializeField]
    private string url = "";

    public void OpenUrl()
    {
        Application.OpenURL(url);
    }
}
