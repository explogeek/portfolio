using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FBVelocityRotator : MonoBehaviour
{
    [SerializeField]
    private float velocityAmplitude = 20.0f;
    [SerializeField]
    private int minAngle = -90;
    [SerializeField]
    private int maxAngle = 90;

    private Rigidbody2D rb; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (velocityAmplitude == 0f)
            velocityAmplitude = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        float effectiveVelocity = Mathf.Clamp(rb.velocity.y, -velocityAmplitude, velocityAmplitude);
        float velocityFactor = effectiveVelocity / velocityAmplitude + 0.5f;
        float targetAngle = Mathf.Lerp(minAngle, maxAngle, velocityFactor);
        float updatedAngle = Mathf.LerpAngle(targetAngle, transform.rotation.eulerAngles.z, 0.5f);
        transform.localRotation = Quaternion.Euler(0f, 0f, updatedAngle);
    }
}
