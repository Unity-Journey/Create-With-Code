using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex = 0;
    private float spawnStartTime = 2.0f;
    private float spawnRepeatTime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartTime, spawnRepeatTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randomSpawn = new Vector3(Random.Range(-9, 9), 0, 15);
        Instantiate(animalPrefabs[animalIndex], randomSpawn, animalPrefabs[animalIndex].transform.rotation);
    }
}
