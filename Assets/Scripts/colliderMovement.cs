using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderMovement : MonoBehaviour
{
    public int speed;

    Rigidbody2D _rigidbody2D;
    Transform _transform;
    GameObject SceneVariables;
    createCollider _createCollider;

    // Start is called before the first frame update
    void Start()
    {
        SceneVariables = GameObject.Find("SceneVariables");

        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        _createCollider = SceneVariables.GetComponent<createCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody2D.velocity = new Vector2(0, -speed);
        if (_transform.position.y < -5)
        {
            _createCollider.createNewCollider();
            Destroy(gameObject);
        }
    }
}
