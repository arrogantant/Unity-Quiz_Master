using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class END : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    Score_Keepr score_Keepr;
    void Start()
    {
        score_Keepr = FindObjectOfType<Score_Keepr>();
    }

    public void showFinalScore()
    {
        finalScoreText.text = "Congratulation!\nYou got a score of" + 
                                score_Keepr.CalculateScore() + "%";
    }
}
