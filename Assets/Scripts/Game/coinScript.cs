using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    GameObject _SceneVariables;
    sceneVariables _sceneVariables;
    GameObject Player;
    playerMovement _playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        _SceneVariables = GameObject.Find("SceneVariables");
        _sceneVariables = _SceneVariables.GetComponent<sceneVariables>();
        Player = GameObject.Find("Player");
        _playerMovement = Player.GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other)
        {
            _sceneVariables.score++;
            _playerMovement.score++;
            Destroy(gameObject);
        }
        
    }
}
