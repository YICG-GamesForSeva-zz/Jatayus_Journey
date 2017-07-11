/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   JatayuGDController.cs
 * 
 * Date Created :   7th July 2017
 * 
 * Purpose      :   Animating Jatayu with the intention of having him speak to the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JatayuGDController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetTrigger("Flap");

        rb2d.velocity = Vector2.zero;
    }
}