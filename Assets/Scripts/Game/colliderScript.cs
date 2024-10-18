using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour
{
    sceneVariables _sceneVariables;

    // Start is called before the first frame update
    void Start()
    {
        _sceneVariables = GameObject.Find("SceneVariables").GetComponent<sceneVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            Debug.Log("Ude¿ono w collider!");
            _sceneVariables.StopGame();
        }
    }
}
