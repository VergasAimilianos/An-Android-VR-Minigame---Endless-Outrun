using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveLazerRay : MonoBehaviour
{
    public GameObject lazerPrefab;
    GameObject lazerShooter;
    Vector3 shooterPosition;

    void Start()
    {
        lazerShooter = GameObject.FindGameObjectWithTag("LazerShooter");
    }

    public void shootLazer()
    {

        shooterPosition = lazerShooter.transform.position;
        lazerPrefab.GetComponent<MoveTowardsTarget>().targetPosition = transform.position;

        if (transform.position.x> 4)
        {
            Instantiate(lazerPrefab, shooterPosition, Quaternion.Euler(90, 45, 0));
        }
        else if (transform.position.x< -4)
        {
            Instantiate(lazerPrefab, shooterPosition, Quaternion.Euler(90, 135, 0));
        }
        else
        {
            Instantiate(lazerPrefab, shooterPosition, Quaternion.Euler(90, 180, 0));
        }
    }
}
