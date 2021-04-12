﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMechanic : MonoBehaviour
{
    public DashState dashState; 
    public float dashTimer; //the maximum time when dashing
    public float maxDash = 20f; //the maximum time of the dash cooldown

    public Vector2 savedVelocity;

    void Update()
    {
        switch (dashState)
        {
            case DashState.Ready: //for when the dash is ready
                var isDashKeyDown = Input.GetKeyDown(KeyCode.LeftShift);
                if (isDashKeyDown)
                {
                    savedVelocity = GetComponent<Rigidbody2D>().velocity;
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x * 3f, GetComponent<Rigidbody2D>().velocity.y);
                    dashState = DashState.Dashing;
                }
                break;
            case DashState.Dashing: //for when your are dashing
                dashTimer += Time.deltaTime * 3;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    GetComponent<Rigidbody2D>().velocity = savedVelocity;
                    dashState = DashState.Cooldown;

                    
                }
                
                break;
            case DashState.Cooldown: //for after dashing
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }
}

public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}

