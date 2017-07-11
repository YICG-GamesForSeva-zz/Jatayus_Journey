/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   MenuBehavior.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   To determine the progress between scenes from the menu, and going through
 *                  all of the progression
 */

using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    public void triggerGame(int trig)
    {
        switch (trig)
        {
            case (0):
                SceneManager.LoadScene("GameDescription");
                break;
            case (1):
                Application.Quit(); 
                break;
            default:
                break;
        }
    }
}