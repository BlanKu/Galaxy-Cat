using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class sceneVariables : MonoBehaviour
{
    public int score;
    public GameObject _ScoreText;
    public bool startGame;

    TextMeshProUGUI _TextMeshProUGUI;

    public GameObject _StartText;
    // Start is called before the first frame update
    void Start()
    {
        _TextMeshProUGUI = _ScoreText.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
       _TextMeshProUGUI.text = score.ToString();

        if(startGame)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        _StartText.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void StopGame()
    {
        Time.timeScale = 0;
    }
}
