using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 3.0f);
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        _animator.SetFloat("Speed", Mathf.Abs(_speed));
        _rigidbody2D.velocity = transform.right * _speed;
    }

    public void SetDirectionRight(bool directionRight)
    {
        _spriteRenderer.flipX = !directionRight;

        if(directionRight == false)
        {
            _speed = -_speed;
        }
    }
}
