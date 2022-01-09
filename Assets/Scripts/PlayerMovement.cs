using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private int wPressed;
    private int sPressed;
    private int aPressed;
    private int dPressed;
    
    

    private Vector3 movementDirection;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MyInput();
    }

    private void MyInput()
    {
        wPressed = Input.GetKey(KeyCode.W) ? 1 : 0;        
        sPressed = Input.GetKey(KeyCode.S) ? 1 : 0;
        aPressed = Input.GetKey(KeyCode.A) ? 1 : 0;
        dPressed = Input.GetKey(KeyCode.D) ? 1 : 0;

        
        var transform1 = transform;
        var forward = transform1.forward;
        var right = transform1.right;
        movementDirection = forward * wPressed + -forward * sPressed + -right*aPressed  + right * dPressed;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.velocity = movementDirection;
    }
}
