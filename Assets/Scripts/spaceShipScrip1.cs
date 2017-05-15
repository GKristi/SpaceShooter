using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class spaceShipScrip1 : MonoBehaviour {


    public GameObject bullet;
    void start()
    {
        
    }



    private void Update()
    { 
        Rigidbody2D r2d = GetComponent<Rigidbody2D>();
        Vector2 vel = r2d.velocity;
        // Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 pos = transform.position;
        if (Input.GetKey("right"))
        {
  
            if (18 >= pos.x) {

                vel.x = 10;
                r2d.velocity = vel;
                
            } else {
                vel.x = 0;
                r2d.velocity = vel;
            }

        } else if (Input.GetKey("left")) {

            if (pos.x >= -18)
            {
                vel.x = -10;
                r2d.velocity = vel;
                
            } else {

                vel.x = 0;
                r2d.velocity = vel;

            }

        }
        else
        {
            vel.x = 0;
            r2d.velocity = vel;
        }

        if (Input.GetKeyDown("space"))
            Instantiate(bullet, transform.position, Quaternion.identity);

    
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }
















}
