using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    private GameManager gameManager;

    private void Start()
    {
        // "GameManager"게임 매니저란 오브젝트가 가진, <GameManager> 스크립트 찾는 코드
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("Ball"))
        {
            if(isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored");
                gameManager.Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 Scored");
                gameManager.Player1Scored();
            }
        }
    }
}
