using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public int speed = -5;

	
	void Start () {
        Rigidbody2D enemy = GetComponent<Rigidbody2D>();        
        enemy.velocity = new Vector2(0, speed);

        // Make the enemy rotate on itself
        enemy.angularVelocity = Random.Range(-200, 200);
    }

    void OnBecameInvisible()
    {        
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D obj)
    {
        name = obj.gameObject.name;
        // Destroy itself (the enemy) and the bullet
        if (name == "bullet(Clone)") {
            Destroy(gameObject);
            Destroy(obj.gameObject);
            handleDestroy(gameObject);
        }
        // If the enemy collided with the spaceship
        if (name == "spaceship")
        {
            // Destroy itself (the enemy) to keep things simple
            Destroy(gameObject);
            //handleDestroy(gameObject);
        }
    }

    void Update () {
		 
	}

    void handleDestroy(GameObject gameObject) {
        GameObject.Find("Score").SendMessage("Hit");
        Destroy(gameObject);
    }
}
