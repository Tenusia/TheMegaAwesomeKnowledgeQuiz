using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Update()
    {
        finalScoreText.text = "Congratulations!\n You got a score of " 
                + scoreKeeper.CalculateScore() + "%\n\n You had " + scoreKeeper.GetCorrectAnswers() 
                + " out of " + + scoreKeeper.GetQuestionsSeen() + " correct.";
    }
}
