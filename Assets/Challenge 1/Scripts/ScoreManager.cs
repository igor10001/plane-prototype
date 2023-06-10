using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component to display the score
    private int score = 0; // Current score

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            // Increment the score when the player passes an obstacle
            score++;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        // Update the TextMeshProUGUI to display the current score
        scoreText.text =  score.ToString();
    }
}
