using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConstantPlayerMovement : MonoBehaviour
{
    public GameObject myGameObject;
    public Rigidbody rb;
    public float constantSpeed = 25;
    public float currentSpeed;
    //public float speedChange = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        rb.transform.position = transform.position + (transform.forward * constantSpeed * Time.deltaTime); // I dont think delta time is needed since we are in fixed update

    }

    /*
    * Movement using the physics system, car would be slowed down by collisions and eventually ramp up to the original speed
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        rb.velocity = transform.forward * constantSpeed;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeed = Vector3.Magnitude(rb.velocity);  // test current object speed

        if (currentSpeed > constantSpeed)

        {
            float brakeSpeed = currentSpeed - constantSpeed;  // calculate the speed decrease

            Vector3 normalisedVelocity = GetComponent<Rigidbody>().velocity.normalized;
            Vector3 brakeVelocity = normalisedVelocity * brakeSpeed;  // make the brake Vector3 value

            GetComponent<Rigidbody>().AddForce(-brakeVelocity);  // apply opposing brake force
        }
        else if (currentSpeed < constantSpeed)
        {
            float accelerateSpeed = constantSpeed - currentSpeed;  // calculate the speed increase

            Vector3 normalisedVelocity = GetComponent<Rigidbody>().velocity.normalized;
            Vector3 accelerateVelocity = normalisedVelocity * accelerateSpeed;  // make the acceleration Vector3 value
            GetComponent<Rigidbody>().AddForce(accelerateVelocity*50);  // apply acceleration force

        }
    }
    */
}
