using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetStatistics : MonoBehaviour
{
    public TMP_Text score;
    public TMP_Text coinscollected;
    GameObject statistics;

    void Start()
    {
        statistics = GameObject.FindGameObjectWithTag("Statistics");
        score.text = statistics.GetComponent<trackStatistics>().score;
        coinscollected.text = statistics.GetComponent<trackStatistics>().coinsCollected;

    }
}
