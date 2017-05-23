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
        Rigidbody2D spaceship = GetComponent<Rigidbody2D>();        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight(spaceship);      
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft(spaceship);
        }
        else
        {
            stopMoving(spaceship);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(bullet, transform.position, Quaternion.identity);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("MainMenu");
    }

    private void MoveRight(Rigidbody2D spaceship)
    {
        Vector2 spaceshipPosition = transform.position;        
        if (18 >= spaceshipPosition.x)
        {            
            spaceship.velocity = new Vector2(10, 0);
        }
        else
        {
            stopMoving(spaceship);
        }
    }

    private void MoveLeft(Rigidbody2D spaceship)
    {
        Vector2 spaceshipPosition = transform.position;        
        if (spaceshipPosition.x >= -18)
        {            
            spaceship.velocity = new Vector2(-10, 0);
        }
        else
        {
            stopMoving(spaceship);
        }

    }

    private void stopMoving(Rigidbody2D spaceship)
    {
        Vector2 spaceshipPosition = transform.position;        
        spaceship.velocity = new Vector2(0, 0);
    } 
}
