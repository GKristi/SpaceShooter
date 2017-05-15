using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public int speed = -5;


	// Use this for initialization
	void Start () {

        Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        Vector2 vel = r2d.velocity;
        vel.y = speed;
        r2d.velocity = vel;

        // Make the enemy rotate on itself
        r2d.angularVelocity = Random.Range(-200, 200);


    }

    void OnBecameInvisible()
    {
        // Destroy the enemy
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


    // Update is called once per frame
    void Update () {
		 
	}

    void handleDestroy(GameObject gameObject) {
        GameObject.Find("Score").SendMessage("Hit");
        Destroy(gameObject);
    }
}
