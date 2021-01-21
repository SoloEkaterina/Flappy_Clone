﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleFish : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocity = 1;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {  //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
}
