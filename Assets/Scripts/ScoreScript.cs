﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {


    public static int score;
    Text text; 
  
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update() {

        text.text = "Score: " + score;
    }

    void Hit()
    {

        score++;

    }
}
