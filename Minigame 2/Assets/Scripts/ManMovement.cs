﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMovement : MonoBehaviour

// reference code from https://www.youtube.com/watch?v=L6Q6VHueWnU
{
    public float moveSpeed = 5f;
    public bool isGrounded = false;
   
    public float yForce;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") & isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, yForce), ForceMode2D.Impulse);
        }
        
    }
}
