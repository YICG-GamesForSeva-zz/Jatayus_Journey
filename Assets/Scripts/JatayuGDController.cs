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