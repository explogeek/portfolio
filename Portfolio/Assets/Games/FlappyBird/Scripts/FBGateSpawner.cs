using UnityEngine;

public class FBGateSpawner : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 2f)]
    private float spawnRate = 1.5f;
    [SerializeField]
    private GameObject gatePrefab = null;
    [SerializeField]
    [Range(0, 100)]
    private float verticalShiftRange = 70f;

    private float lastSpawnTime = 0.0f;

    void Update()
    {
        if (Time.time - lastSpawnTime > spawnRate)
        {
            lastSpawnTime = Time.time;
            Transform spawnerTransform = this.gameObject.transform;
            float yShift = verticalShiftRange / 45;
            float spawnPositionY = spawnerTransform.position.y + Random.Range(-yShift, yShift);
            Vector3 spawnPosition = new Vector3(spawnerTransform.position.x, spawnPositionY, spawnerTransform.position.z);
            // TODO: Pooling
            Instantiate(gatePrefab, spawnPosition, spawnerTransform.rotation);
        }
    }
}
