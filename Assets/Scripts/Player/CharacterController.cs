using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;

    protected SpriteRenderer _spriteRenderer;
    protected Animator _animator;

    public void CallMoveEvent(Vector2 dir)
    {
        AnimatorSetBool(dir);
        SpriteFlip(dir);
        OnMoveEvent?.Invoke(dir);
    }
    
    private void AnimatorSetBool(Vector2 dir)
    {
        if (dir != Vector2.zero)
        {
            _animator.SetBool("IsRun", true);
        }
        else
        {
            _animator.SetBool("IsRun", false);
        }
    }

    private void SpriteFlip(Vector2 dir)
    {
        if(dir.x < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else
        {
            _spriteRenderer.flipX = false;
        }
    }
}
