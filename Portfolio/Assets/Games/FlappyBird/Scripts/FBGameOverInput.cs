using UnityEngine;

public class FBGameOverInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<FBGameManager>().Reload();
        }
    }
}
