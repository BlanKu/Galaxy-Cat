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
    GameObject GameOverUI;

    public bool gameOver;

    GameObject Player;

    Rigidbody2D _playerRigidBody2D;
    BoxCollider2D _playerBoxCollider2D;
    Animator _playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _TextMeshProUGUI = _ScoreText.GetComponent<TextMeshProUGUI>();
        GameOverUI = GameObject.Find("GameOverUI");

        Player = GameObject.Find("Player");

        _playerRigidBody2D = Player.GetComponent<Rigidbody2D>();
        _playerBoxCollider2D = Player.GetComponent<BoxCollider2D>();
        _playerAnimator = Player.GetComponent<Animator>();

        GameOverUI.SetActive(false);

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
        _playerRigidBody2D.gravityScale = 1.0f;
        _playerBoxCollider2D.isTrigger = true;
        _playerAnimator.Play("playerDeath");
        GameOverScreen();
    }

    public void GameOverScreen()
    {
        GameOverUI.SetActive(true);
    }

    public IEnumerator PlayerRevive()
    {
        Player.transform.position = new Vector2(0, 0);
        _playerRigidBody2D.gravityScale = 0;
        _playerAnimator.Play("playerRevive");
        yield return new WaitForSeconds(3);
        _playerBoxCollider2D.isTrigger = false;
    }
}
