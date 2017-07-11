/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   ScrollingObject.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   To have the ability for the background to move thereby creating the illusion for the 
 *                  humans to think that Jatayu is moving from left to right
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;   // Having the private annotation, this variable can only be modified in the context of this

    // Use this for initialization
    void Start()
    {
        // Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();

        // Start the object moving.
        rb2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // If the game is over, stop the scrolling
        if (GameController.instance.gameOver == true || GameController.instance.birdLanded == true)
        {
            rb2d.velocity = Vector2.zero;
        }
        else
        {
           rb2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
        }
    }
}