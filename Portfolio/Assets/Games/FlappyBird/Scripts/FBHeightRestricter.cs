using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBHeightRestricter : MonoBehaviour
{
    [SerializeField]
    private float maxHeight = 5.6f;

    void Update()
    {
        if (transform.position.y > maxHeight)
            transform.position = new Vector2(transform.position.x, maxHeight);
    }
}
