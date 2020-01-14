using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class FBPlayerInput : MonoBehaviour
{
    public UnityEvent jumpPressed;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpPressed.Invoke();
        }
    }
}
