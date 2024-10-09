using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneVariables : MonoBehaviour
{
    public int score;
    public GameObject _ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ScoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
