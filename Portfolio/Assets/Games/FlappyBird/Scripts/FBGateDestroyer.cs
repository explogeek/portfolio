﻿using UnityEngine;

public class FBGateDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FBMover>() != null)
        {
            Destroy(collision.gameObject);
        }
    }
}