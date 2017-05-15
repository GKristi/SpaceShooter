using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletScript : MonoBehaviour {

    public int speed = 6;
    
    void Start() {
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();               
        r2d.velocity = new Vector2(0, speed);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
