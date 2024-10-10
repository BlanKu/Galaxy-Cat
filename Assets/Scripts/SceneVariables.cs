using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class sceneVariables : MonoBehaviour
{
    public int score;
    public GameObject _ScoreText;
    TextMeshProUGUI _TextMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        _TextMeshProUGUI = _ScoreText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
       _TextMeshProUGUI.text = score.ToString();
    }
}
