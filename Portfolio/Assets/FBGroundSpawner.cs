using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBGroundSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject groundPrefab = null;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != "Ground")
            return;
        Transform transform = collision.gameObject.transform;
        float width = collision.gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        // TODO: Pooling
        float xPosition = transform.position.x + width;
        var spawnPosition = new Vector2(xPosition, transform.position.y);
        Instantiate(groundPrefab, spawnPosition, transform.rotation);
    }
}
