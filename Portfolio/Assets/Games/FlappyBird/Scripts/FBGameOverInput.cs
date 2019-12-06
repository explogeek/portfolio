using UnityEngine;
using UnityEngine.SceneManagement;

public class FBGameOverInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
