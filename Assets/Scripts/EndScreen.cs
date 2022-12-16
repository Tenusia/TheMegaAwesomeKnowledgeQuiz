using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        // Debug.Log("Seen: " + scoreKeeper.GetQuestionsSeen());
        // Debug.Log("Score: " + scoreKeeper.CalculateScore());
        //finalScoreText.text = "Congratulations!\n You got a score of " + scoreKeeper.CalculateScore() + "%";
        //finalScoreText.text = "You had " + scoreKeeper.GetCorrectAnswers() + "out of " + + scoreKeeper.GetQuestionsSeen() + "correct.";
    }
}