using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class sceneVariables : MonoBehaviour
{
    public int score;
    public GameObject _ScoreText;

    TextMeshProUGUI _TextMeshProUGUI;

    public GameObject _StartText;

    public bool gameOver;

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        _TextMeshProUGUI = _ScoreText.GetComponent<TextMeshProUGUI>();
        Player = GameObject.Find("Player");

        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
       _TextMeshProUGUI.text = score.ToString();
    }

    public void StartGame()
    {
        if (!gameOver)
        {
            _StartText.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }

    public void StopGame()
    {
        gameOver = true;
        Player.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
        Player.GetComponent<BoxCollider2D>().isTrigger = true;
        Player.GetComponent<Animator>().Play("playerDeath");
    }
}
