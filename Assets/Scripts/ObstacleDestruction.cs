using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestruction : MonoBehaviour
{
    GameObject gameContainer;
    private void Start()
    {
        gameContainer = GameObject.FindGameObjectWithTag("GameComponents");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("collision detected, obstacle Z= " + transform.position.z);

            gameContainer.GetComponent<HealthManagement>().decreaseHealth(transform.position.z);
            Destroy(gameObject);
        }
    }
    
    public void destroyOnPointerEnter()
    {

        if (gameObject.tag == "ReticleDestructible")
        {
            Destroy(gameObject);
        }
    }

}
