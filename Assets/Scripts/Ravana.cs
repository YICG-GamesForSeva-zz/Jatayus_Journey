/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   Ravana.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   This script will be outlining the logic for the columns (or for Ravana and his swords).
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ravana : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<JatayuController>() != null)
        {
            // If Jatayu hits the trigger collider, in between the 
            // swords, then tell the game control that Jatayu has scored a point
            GameController.instance.BirdScored(); 
        }
    }
}