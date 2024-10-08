using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreTracking : MonoBehaviour
{
    public GameObject statistics;
    public Transform playerPosition;
    public TMP_Text scoreUI;
    int coinScore = 0;
    float zPosition;
    string score;

    private void Start()
    {
        
    }
    void Update()
    {
        zPosition = playerPosition.position.z;
        zPosition = zPosition / 100;
        score = zPosition.ToString("0") + coinScore.ToString();
        scoreUI.text = score;
        statistics.GetComponent<trackStatistics>().score = score;
        statistics.GetComponent<trackStatistics>().coinsCollected = (coinScore/5).ToString();

    }

    public void increaseScore()
    {
        coinScore += 5;
    }
}
