using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private string playerTag;
    public Player player;
    public int playerId;

    public string playerName;

    public Transform PlayerTransform { get; private set; } // 플레이어 transform

    private void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this;
        playerId = 0;
    }

    public void GameStart()
    {
        player.gameObject.SetActive(true);
        PlayerTransform = GameObject.FindGameObjectWithTag(playerTag).transform;
        // 플레이어 태그를 검색하여, 플레이어 오브젝트를 찾고 transform값을 가져옴
    }

    public void SetId(int id)
    {
        playerId = id;
    }
}
