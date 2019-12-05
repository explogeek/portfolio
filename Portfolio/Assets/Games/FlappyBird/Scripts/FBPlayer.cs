using System;
using UnityEngine;

public class FBPlayer : MonoBehaviour
{

    public static event Action OnHit = delegate { };
    public static event Action OnGatePass = delegate { };

    [SerializeField]
    [Range(100, 800)]
    private int jumpForce = 250;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<FBMover>() != null)
            OnGatePass();
        else
            OnHit();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnHit();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = rb.velocity / 5;
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
}
