﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBMover : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction = Vector2.zero;
    [SerializeField]
    private float speed = 1f;

    private static bool shouldMove = true;

    private void Awake()
    {
        direction = direction.normalized;
    }

    private void Update()
    {
        if (shouldMove)
            this.transform.Translate(direction * Time.deltaTime * speed);
    }

    public static void Stop()
    {
        shouldMove = false;
    }
}
