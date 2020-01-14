using UnityEngine;
using UnityEngine.Events;

public class PauseManager : MonoBehaviour
{
    public bool isCheckingInput = true;
    public UnityEvent paused, resumed;
    private bool isPaused = false;

    private void Awake()
    {
        Resume();
    }

    public void Toggle()
    {
        if (isPaused)
            Resume();
        else
            Pause();
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        paused.Invoke();
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;
        resumed.Invoke();
    }

    private void Update()
    {
        if (isCheckingInput && Input.GetButtonDown("Cancel"))
        {
            Toggle();
        }
    }
}
