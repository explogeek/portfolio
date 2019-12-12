using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FBInputManager : MonoBehaviour
{
    public UnityEvent cancelPressed;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            cancelPressed.Invoke();
        }
    }
}
