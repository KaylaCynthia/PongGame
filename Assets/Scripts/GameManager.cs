using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    [SerializeField] private GameObject ball;

    [Header("Players")]
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;

    [Header("Goals")]
    [SerializeField] private GameObject player1Goal;
    [SerializeField] private GameObject player2Goal;

    [Header("Scores")]
    [SerializeField] private TextMeshProUGUI player1ScoreText;
    [SerializeField] private TextMeshProUGUI player2ScoreText;

    private int player1Score = 0;
    private int player2Score = 0;
    
    public void Player1Scored()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1.GetComponent<PlayerMovement>().Reset();
        player2.GetComponent<PlayerMovement>().Reset();
    }
}
