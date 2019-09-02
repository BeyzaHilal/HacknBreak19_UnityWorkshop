using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AsteroidSpawner : MonoBehaviour
{
    public GameObject AsteroidPrefab;
    public Vector2 SpawnPositionXRange;
    public float SpawnPositionY;
    public float WaitTimeForSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAsteroid());
    }
   
    private IEnumerator SpawnAsteroid()
    {
        while (true)
        {
           
                Vector2 position = new Vector2(Random.Range(SpawnPositionXRange.x, SpawnPositionXRange.y),
                    SpawnPositionY);
                Instantiate(AsteroidPrefab, position, Quaternion.identity);
            

            yield return new WaitForSeconds(WaitTimeForSpawn);
        }
    }
}
