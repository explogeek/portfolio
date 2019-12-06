using System;
using UnityEngine;

public class FBPlayer : MonoBehaviour
{
    public static event Action OnHit = delegate { };
    public static event Action OnGatePass = delegate { };

    [SerializeField]
    [Range(100, 800)]
    private int jumpForce = 250;
    [SerializeField]
    private string gateTag = "Gate";

    private Rigidbody2D rb;
    private bool didHitObstacle = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FBObstacle>() != null)
            HitObstacle();
        else if (collision.tag == gateTag)
            OnGatePass();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HitObstacle();
    }

    private void HitObstacle()
    {
        if (!didHitObstacle)
        {
            didHitObstacle = true;
            rb.velocity = Vector2.zero;
            OnHit();
        }
    }

    public void Jump()
    {
        rb.velocity = rb.velocity / 5;
        rb.AddForce(new Vector2(0f, jumpForce));
    }
}
