using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour
{
    private int life = 100;
    private Text text;

    void Start() {
        text = GetComponent<Text>();
    }

    void Update() {
        text.text = "Life: " + life + "%";
    }

    void DecreaseLife()
    {
        if (life > 0)
            life = life - 25;
        else
            OnGUI(); 
    }
    private void OnGUI()
    {
        if (life <= 0)
            GUI.Label(new Rect(300, 250, 100, 100), "Game Over");
    }

}