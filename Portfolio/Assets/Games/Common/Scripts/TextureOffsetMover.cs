using UnityEngine;

public class TextureOffsetMover : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction = Vector2.zero;
    [SerializeField]
    private float speed = 1f;

    private static bool shouldMove = false;

    private Renderer r;
    private Vector2 offset;

    private void Awake()
    {
        direction = direction.normalized;
        r = gameObject.GetComponent<Renderer>();
        offset = direction * speed/100f;
    }

    private void Update()
    {
        if (shouldMove)
            r.material.mainTextureOffset += offset * Time.deltaTime;
    }

    public static void Stop()
    {
        shouldMove = false;
    }

    public static void Start()
    {
        shouldMove = true;
    }
}
