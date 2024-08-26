using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3Data spawnPosition;
    //public GameObject textObj;
    
    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        float randomX = Random.Range(-8f, 8f);
        float randomY = Random.Range(-5f, 5f);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

        spawnPosition = ScriptableObject.CreateInstance<Vector3Data>();
        spawnPosition.position = randomPosition;
        
        Instantiate(objectToSpawn, spawnPosition.position, Quaternion.identity);
        // GameObject spawnObj = Instantiate(objectToSpawn, spawnPosition.position, Quaternion.identity);
        //spawnObj.textObj = textObj;
    }
}