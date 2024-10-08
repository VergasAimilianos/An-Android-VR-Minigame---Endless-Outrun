using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HealthManagement : MonoBehaviour
{
    bool demonstration = true;
    int Health = 5;
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    public Image Heart4;
    public Image Heart5;
    float lastObstacleZhit = 0;

    List<Image> hearts = new List<Image>();

    private void Start()
    {
        hearts.Add(Heart1);
        hearts.Add(Heart2);
        hearts.Add(Heart3);
        hearts.Add(Heart4);
        hearts.Add(Heart5);
    }


    public void decreaseHealth(float obstacleZposition)
    {
        
        if (obstacleZposition != lastObstacleZhit)
        {
            lastObstacleZhit = obstacleZposition;
            Health--;
            
            if (Health >= 0) hearts[Health].enabled = false;
        }
    }
    public void increaseHealth()
    {
        if(Health<=4)
        {
            Health++;
            hearts[Health].enabled = true;
        }

    }

    private void Update()
    {
        if (Health <= 0 && demonstration)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(2);
        }
    }


}
