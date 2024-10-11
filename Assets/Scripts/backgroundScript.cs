using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    public float speed;
    public float x_multiply;
    public float y_multiply;

    Rigidbody2D _rigidbody2D;
    Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); 
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector3(-speed*x_multiply, -speed*y_multiply, 3);
        if(_transform.position.x <= -6)
        {
            _transform.position = new Vector3(0, 3, 3);
        }
        if (_transform.position.y <= -20)
        {
            Destroy(gameObject);
        }
    }
}
