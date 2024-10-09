using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int speed;
    public double actualSpeed;

    BoxCollider2D _boxColider2D;
    Rigidbody2D _rigidbody2D;
    Transform _transform;
    SpriteRenderer _spriteRender;
    // Start is called before the first frame update
    void Start()
    {
        _boxColider2D = GetComponent<BoxCollider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        _spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //_transform.Rotate(0, 0, Math.Abs(actualSpeed)*90);

        if(Input.GetKeyDown(KeyCode.A))
        {
            _rigidbody2D.velocity = new Vector2(-speed,_rigidbody2D.velocity.y);
            _spriteRender.flipX = false;
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _rigidbody2D.velocity = new Vector2(speed,_rigidbody2D.velocity.y);
            _spriteRender.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        actualSpeed = Math.Round(_rigidbody2D.velocity.x,2);
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, 1);

        _transform.rotation = Quaternion.Euler(0, 0, -(float)actualSpeed * (90/speed));
    }
}
