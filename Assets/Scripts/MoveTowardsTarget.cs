using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour
{

    public Vector3 targetPosition;
    float speed = 40.0f;

    private void Update()
    {
        if(targetPosition != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

        if (transform.position == targetPosition) Destroy(gameObject);
    }

}
