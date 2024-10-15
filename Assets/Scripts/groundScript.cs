using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundScript : MonoBehaviour
{
    public float speedX, speedY;

    Rigidbody2D _rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _rigidBody2D.velocity = new Vector2(speedX, speedY);

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
