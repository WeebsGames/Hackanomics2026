using System;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class CarMovement : MonoBehaviour
{
    public float speed = 25.0f;
    public float maxSpeed = 10.0f;

    Rigidbody rb;
    Transform t;
    Vector3 dir = new Vector3(0,0,0);
    float turn = 0.0f;
    float turnLimit = 30.0f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            dir += t.forward;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            dir -= t.forward;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            turn += 5;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            turn -= 5;
        }

        if(turn < -30.0f)
        {
            turn = -30.0f;
        } else if(turn > 30.0f)
        {
            turn = 30.0f;
        }

        if(rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.linearVelocity += dir * speed * Time.deltaTime;
        }
        //reset directional input
        dir = Vector3.zero;

    }
}
