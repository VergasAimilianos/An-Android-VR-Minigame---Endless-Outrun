using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustTiltSensitivity : MonoBehaviour
{
    public float speed = 25;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void adjustSensitivity(float newSpeed)
    {
        speed = newSpeed;
    }
}
