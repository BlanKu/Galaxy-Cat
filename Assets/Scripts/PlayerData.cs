using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int totalScore;
    public int maxScore;

    public PlayerData(playerMovement player)
    {
        totalScore = totalScore + player.score;
        maxScore = player.recordScore;
    }
}
