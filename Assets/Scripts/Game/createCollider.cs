using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class createCollider : MonoBehaviour
{
    public GameObject Collider;
    public float range;
    void Start()
    {
        for(int i = 1; i < 5; i++)
        {
            Instantiate(Collider, new Vector2(Random.Range(-range,range), i * 5), new Quaternion());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createNewCollider()
    {
        Instantiate(Collider, new Vector2(Random.Range(-range, range), 15), new Quaternion());
    }
}
