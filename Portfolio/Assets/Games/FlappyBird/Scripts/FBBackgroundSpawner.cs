using UnityEngine;

public class FBBackgroundSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab = null;
    [SerializeField]
    private string prefabTag = "bgSpawnable";

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != prefabTag)
            return;
        Transform transform = collision.gameObject.transform;
        float width = collision.gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        // TODO: Pooling
        float xPosition = transform.position.x + width;
        var spawnPosition = new Vector2(xPosition, transform.position.y);
        Instantiate(prefab, spawnPosition, transform.rotation, this.gameObject.transform);
    }
}
