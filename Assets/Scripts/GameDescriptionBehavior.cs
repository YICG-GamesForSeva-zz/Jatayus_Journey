/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   GameDescriptionBehavior.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   This script will be able to have all of the UI functionality to determine the transition
 *                  from the game description to the actual game called "Main"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDescriptionBehavior : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    public void progressTrigger(int ind)
    {
        switch (ind)
        {
            case (0):
                SceneManager.LoadScene("Main");
                break;
            case (1):
                SceneManager.LoadScene("Menu");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}