using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    // Variable to store the enemy prefab
    public GameObject enemy;
    // Variable to know how fast we should create new enemies
    public float spawnTime = 2;
    
	void Start ()
    {
        InvokeRepeating("AddEnemy", 0, spawnTime);
	}
	
    void AddEnemy() {
        Renderer rd = GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x / 2;
        float x2 = transform.position.x + rd.bounds.size.x / 2;
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        // Create an enemy at the 'spawnPoint' position
        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
}
