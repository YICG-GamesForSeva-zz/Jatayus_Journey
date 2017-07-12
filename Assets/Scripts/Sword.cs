/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   Sword.cs
 * 
 * Date Created :   12th July 2017
 * 
 * Purpose      :   This script will be outlining the logic for the columns (or for Ravana and his swords, or just 
 *                  Ravana's swords).
 * 
 * Changed on 12th July 2017 - Renamed Ravana.cs to Sword.cs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
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