using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    GameObject gameContainer;

    void Start()
    {
        gameContainer = GameObject.FindGameObjectWithTag("GameComponents");
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("collision detected");
            Destroy(gameObject);
            gameContainer.GetComponent<ScoreTracking>().increaseScore();
            gameContainer.GetComponent<GameManager>().playCoinSound();
        }
    }

    
}
