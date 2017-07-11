/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   GameController.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   To be able to determine the overall game logic
 */

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;  // Create a public and static reference to be used throughout the game - and the use of static, I may not even
                                            // have to use the new syntax to create an instance

    public Text scoreText;                  // Holding the score value
    public GameObject gameOverText;         // A reference to hold the gameOverText

    private int score = 0;                  // The player's score
    public bool gameOver = false;           // Is the game really over?
    public bool birdLanded = false;         // Having the marker if Jatayu has landed
    public float scrollSpeed = -1.5f;       // The speed for which the background moves

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // The method of showing the bird scored
    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        else
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    // The method to run if the bird has hit the sword (BirdDied)
    public void BirdDied()
    {
        // Activate the game over text block
        gameOverText.SetActive(true);

        // Note that the game is actually over
        gameOver = true;
    }
}