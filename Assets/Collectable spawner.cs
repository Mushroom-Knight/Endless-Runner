using UnityEngine;

public class collectableSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float minSpawnTime = 1.0f;
    public float maxSpawnTime = 2.0f;


    private void Start()
    {
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);

    }
    private void Update()
    {
        //add Time.DeltaTime returnsthe amount of time passed since the last frame.
        // This will create a float that counts up in seconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;
    }
}
