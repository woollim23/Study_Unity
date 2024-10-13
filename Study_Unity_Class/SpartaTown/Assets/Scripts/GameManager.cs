using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public int playerId;

    private string playerName;

    private void Awake()
    {
        instance = this;
        playerId = 0;
    }

    public void GameStart()
    {
        player.gameObject.SetActive(true);
        
    }

    public void SetId(int id)
    {
        playerId = id;
    }

    public void InputPlayerName(string name)
    {
        playerName = name;
    }
}
