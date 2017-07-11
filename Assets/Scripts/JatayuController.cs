/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy
 * 
 * Project      :   Jatayu's Journey
 * 
 * File Name    :   JatayuController.cs
 * 
 * Date Created :   11th July 2017
 * 
 * Purpose      :   To determine the logic for our character Jatayu - who can do the following:
 *                  - Flap wings
 *                  - Land (if the player gets tired)
 *                  - Die (if he hits the sword)
 */

using UnityEngine;

public class JatayuController : MonoBehaviour
{
    public float upForce = 200f;           // Upward force for Jatayu to "flap" his wings.
    private bool isDead = false;    // Has the player collided with a sword? Or even the ground?

    private Animator anim;
    private Rigidbody2D jatayuRb2d;

    // Use this for initialization
    void Start()
    {
        // Get reference to the Animator component attached to Jatayu for the animation to flap
        anim = GetComponent<Animator>();

        // Get the reference for Jatayu (our Bird) and the Rigidbody2D that is attached.
        jatayuRb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Don't allow the control if the bird has died
        if (isDead == false)
        {
            // Looking for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                // Tell the animator to change states - Flap
                anim.SetTrigger("Flap");

                // Zero out Jatayu's vertical velocity (in the Y-axis)
                jatayuRb2d.velocity = Vector2.zero;

                // Provide Jatayu with some lift!
                jatayuRb2d.AddForce(new Vector2(0, upForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            // Go to the Land sprite - Jatayu lands on the ground
            anim.SetTrigger("Land");

            // Zero out Jatayu's velocity vertically (in the Y-axis)
            jatayuRb2d.velocity = Vector2.zero;

            // Setting the scrolling to stop
            GameController.instance.birdLanded = true;
        }

        if (other.gameObject.tag == "Sword")
        {
            // Zero out Jatayu's velocity
            jatayuRb2d.velocity = Vector2.zero;

            // Now Jatayu is dead
            isDead = true;

            // Go to the Dead sprite - Jatayu has both wings cut off
            anim.SetTrigger("Die");

            //...and tell the GameController about it (this will be written but commented)
            GameController.instance.BirdDied();
        }
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Letting the game controller know that Jatayu is flying
           GameController.instance.birdLanded = false;

            // Tell the animator to change states -Flap
            anim.SetTrigger("Flap");

            // Zero out Jatayu's vertical velocity (in the Y-axis)
            jatayuRb2d.velocity = Vector2.zero;

            // Provide Jatayu with some lift!
           jatayuRb2d.AddForce(new Vector2(0, upForce));

            // Resuming the scrolling
            GameController.instance.scrollSpeed = -1.5f;
        }
    }
}