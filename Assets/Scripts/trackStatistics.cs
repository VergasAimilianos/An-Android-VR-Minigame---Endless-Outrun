using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackStatistics : MonoBehaviour
{
    public string score;
    public string coinsCollected;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
