using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _moveDir = Vector2.zero;
    private Rigidbody2D _rigidbody;
    
    [SerializeField] private float speed;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    void FixedUpdate()
    {
        ApplyMovement(_moveDir);
    }

    private void Move(Vector2 dir)
    {
        _moveDir = dir;
    }

    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * speed;

        _rigidbody.velocity = dir;
    }
}
