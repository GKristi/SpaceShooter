using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour {
    
    [Header("Bullet Properties")]
    public int speed = 6;
    
    //Private variables...
    private Rigidbody2D r2d;
    
    void Start()
    {
        if(r2d == null)
            r2d = GetComponent<Rigidbody2D>();               
        r2d.velocity = new Vector2(0, speed);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
