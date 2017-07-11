/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   RepeatingBackground.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   This script will contain the proper logic to fully 
 *                  ensure that the background can repeat for Jatayu to fly
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;       // This stores a reference to the collider attached to the Ground game object
    private float groundHorizontalLength;       // A float to store the x-axis length of the collider2D attached to the game object

    // Awake is called before Start
    void Awake()
    {
        // Get and store a reference to the collider2D attached to Ground.
        groundCollider = GetComponent<BoxCollider2D>();

        // Store the size of the collider along the x-axis (its length in units).
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update runs once per fame
    void Update()
    {
        /*
         * Check if the difference along the x-axis between the Main Camera and the position
         * of the object this is attached to is greater than groundHorizontalLength value
         */
        if (transform.position.x < -groundHorizontalLength)
        {
            /*
             * If true, this means that this object is no longer visible and we can safely move
             * it forward to be re-used
             */
            RepositionBackground();
        }
    }

    /// <summary>
    /// Moves the object this script is attached to towards the right
    /// in order to create our looping background effect.
    /// </summary>
    private void RepositionBackground()
    {
        // This is how far towards the right we will move our background object, 
        // in this case, twice its length. This will position it directly to the right
        // of the currently visible background object.
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);

        // Move this object from it's position offscreen, behind the player, to 
        // the new position off-camera in front of the player.
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}