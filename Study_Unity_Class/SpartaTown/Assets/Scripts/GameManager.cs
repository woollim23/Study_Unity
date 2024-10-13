using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public int playerId;

    public string playerName;

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
}
