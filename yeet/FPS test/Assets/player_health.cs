﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DecreaseHealth()
    {
        health--;
        if (health<= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
