using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public Ball ball;

    [Header("Player 1")]
    public Paddle player1Paddle;
    public Goal player1Goal;

    [Header("Player 2")]
    public Paddle player2Paddle;
    public Goal player2Goal;

    [Header("UI")]
    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;

    private int player1Score;
    private int player2Score;

    public void Player1Scored()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()// 포지션 reset을 실행하는 함수, 실행 함수가 뭘까? 바로 실행 할 수 있다는 뜻인가?
    {
        ball.Reset(); // reset은 이벤트 함수 이지만 실행 할 수도 있다.
        player1Paddle.Reset();
        player2Paddle.Reset();        
    }
}
