using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // public GameObject objectToSpawn;
    public Vector3Data spawnPosition;
    
    void Start()
    {
    //    SpawnObject();
    }

    /*void SpawnObject()
    {
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(-10f, 10f);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);
        
        spawnPosition.position = randomPosition;
        
        Instantiate(objectToSpawn, spawnPosition.position, Quaternion.identity);
    }*/
    
    void SetRandomPosition()
    {
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(-10f, 10f);
        spawnPosition.position.x = randomX;
        spawnPosition.position.y = randomY;
                
        //transform.position = spawnPosition;
    }
}
