/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   RavanaPool.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   This script will be having all of the Ravana columns with 
 *                  his head.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavanaPool : MonoBehaviour
{
    public GameObject ravanaPrefab;
    public int ravansPoolSize = 5;
    public float spawnRate = 3f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

    private GameObject[] columns;
    private int currentColumn = 0;

    private Vector2 ravanaPoolPosition = new Vector2(-15, -25);
    private float spawnXPosition = 10f;

    private float timeSinceLastSpawned;

    void Start()
    {
        timeSinceLastSpawned = 0f;

        //Initialize the columns collection
        columns = new GameObject[ravansPoolSize];

        // Loop through the collection
        for (int i = 0; i < ravansPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(ravanaPrefab, ravanaPoolPosition, Quaternion.identity);
        }
    }

    // Spawn columns as long as the game is not over
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameController.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;

            // Set a random y position for Ravana
            float spawnYPosition = Random.Range(columnMin, columnMax);

            //...then set the current column to that position.
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            // Increase the value of the currentColumn. If the new size is
            // too big, reset it back to zero.
            currentColumn++;

            if (currentColumn >= ravansPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}