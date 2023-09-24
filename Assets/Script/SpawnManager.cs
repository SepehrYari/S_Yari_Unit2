using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] AnimalPrefabs;
    private float xPosRange = 13.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpawnRandomAnimal()
    {
        float randxPos = Random.Range(-xPosRange, xPosRange);
        int AnimalPrefabsIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 randPOS = new Vector3(randxPos, 0, 21);
        Instantiate(AnimalPrefabs[AnimalPrefabsIndex], new Vector3(randxPos, 0, 21), AnimalPrefabs[AnimalPrefabsIndex].transform.rotation);
    }



}
