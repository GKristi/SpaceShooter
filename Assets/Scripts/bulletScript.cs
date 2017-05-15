using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletScript : MonoBehaviour {

     public int speed = 6;



    // Use this for initialization
    void Start() {

        Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        Vector2 vel = r2d.velocity;
        vel.y = speed;
        r2d.velocity = vel;

    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }



}
