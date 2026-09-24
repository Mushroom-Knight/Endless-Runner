using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;


        private void Start()
    {
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);

    }

    private void Update()
    {
        //add Time.DeltaTime returnsthe amount of time passed since the last frame.
        // This will create a float that counts up in seconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //if weve counted past the amount of time we need to wait
        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            //use Random.Range to pick a numbeer between 0 and the amount of itmes we have on our object list
            int selection = Random.Range(0, objectsToSpawn.Length);

            //instantiate spawns in gameobject - in this case we tell it to spawn a gameobject from our objectstospawn list
            //the secpnds parameter in the brackets tell its where to spawn, so we've entered the position for the spawner
            // the third [ara,eter os for rotation, and quaternion.identity means no rotation
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);

            //after spawning, we select a new random time for the next spawn and set out timer backto zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;
        }
    }
}

