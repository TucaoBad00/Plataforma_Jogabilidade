using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject playerPrefab;

    [Header("Enemy")]
    public List<GameObject> enemy;

    [Header("References")]
    public Transform startPoint;
    private GameObject _currentPlayer;

    [Header("Animation")]
    public float duration;
    public float delay;
    public void Start()
    {
        Init();
    }
    public void Init()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        _currentPlayer = Instantiate(playerPrefab);
        _currentPlayer.transform.position = startPoint.transform.position;
    }
}
