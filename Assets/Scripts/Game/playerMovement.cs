using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public int speed;
    public double actualSpeed;
    public int score;
    public int recordScore;

    BoxCollider2D _boxColider2D;
    Rigidbody2D _rigidbody2D;
    Transform _transform;
    SpriteRenderer _spriteRender;

    public GameObject _LeftButton;
    public GameObject _RightButton;

    public sceneVariables _sceneVariables;

    Button _leftButtonButton;
    Button _rightButtonButton;
    // Start is called before the first frame update
    void Start()
    {
        _boxColider2D = GetComponent<BoxCollider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        _spriteRender = GetComponent<SpriteRenderer>();

        _leftButtonButton = _LeftButton.GetComponent<Button>();
        _rightButtonButton = _RightButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerGoLeft();

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerGoRight();
        }
    }

    private void FixedUpdate()
    {
        actualSpeed = Math.Round(_rigidbody2D.velocity.x, 2);

        _transform.rotation = Quaternion.Euler(0, 0, -(float)actualSpeed * (90 / speed));

    }

    public void PlayerGoLeft()
    {
        _rigidbody2D.velocity = new Vector2(-speed, _rigidbody2D.velocity.y);
        _spriteRender.flipX = false;
        _sceneVariables.StartGame();

    }

    public void PlayerGoRight()
    {
        _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y);
        _spriteRender.flipX = true;
        _sceneVariables.StartGame();

    }
}
    
