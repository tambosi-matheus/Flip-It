using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    public PlayerController player;
    public TextMeshProUGUI score, highScore, trickScore;


    public void UpdateScore()
    {
        score.text = player.score.ToString();
        trickScore.text = player.trickScore.ToString();
    }

    public void UpdateTrickScore()
    {
        trickScore.text = player.trickScore.ToString();
    }
}
