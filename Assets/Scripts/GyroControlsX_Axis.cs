using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControlsX_Axis : MonoBehaviour
{
    Gyroscope gyro;
    public Rigidbody rb;
    public float speed = 25f;
    GameObject tiltSpeedContainer;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        gyro = Input.gyro;
        gyro.enabled = true;
        //Input.gyro.updateInterval = 0.0167f; 
        // 60Hz = 0.0167f
        // 30Hz = 0.0333f
        tiltSpeedContainer = GameObject.Find("TiltSensitivity");
        speed = tiltSpeedContainer.GetComponent<AdjustTiltSensitivity>().speed;
        Debug.Log("Speed:" + speed);
    }

    void FixedUpdate()
    {
        if (speed == 0) speed = 25f;
        rb.transform.position = transform.position + new Vector3(Input.acceleration.x * speed * Time.deltaTime, 0, 0); 
    }

    

}
