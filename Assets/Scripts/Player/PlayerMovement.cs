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
        MoveLimit();

        _rigidbody.velocity = dir;

        
    }

    private void MoveLimit()    // 캐릭터가 화면 밖으로 넘어가지 않도록 설정
    {
        Vector2 myPos = transform.position;

        if(myPos.x < -2.3f)
        {
            myPos.x = -2.3f;
        }
        else if(myPos.x > 2.3f)
        {
            myPos.x = 2.3f;
        }

        transform.position = myPos;
    }
}
