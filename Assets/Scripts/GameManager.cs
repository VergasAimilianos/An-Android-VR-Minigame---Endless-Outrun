using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerCar;
    public GameObject terrain;
    public GameObject Obstacle1;
    public GameObject Obstacle1Destr;
    public GameObject Obstacle2;
    public GameObject Obstacle2Destr;
    public GameObject Obstacle3;
    public GameObject Obstacle3Destr;
    public GameObject Obstacle4;
    public GameObject Obstacle4Destr;
    public GameObject Obstacle5;
    public GameObject Obstacle5Destr;
    List<GameObject> obstaclesList = new List<GameObject>();
    public GameObject Coin;
    public AudioSource coinSound;


    float terrainN;


    void Start()
    {
        obstaclesList.Add(Obstacle1);
        obstaclesList.Add(Obstacle1Destr);
        obstaclesList.Add(Obstacle2);
        obstaclesList.Add(Obstacle2Destr);
        obstaclesList.Add(Obstacle3);
        obstaclesList.Add(Obstacle3Destr);
        obstaclesList.Add(Obstacle4);
        obstaclesList.Add(Obstacle4Destr);
        obstaclesList.Add(Obstacle5);
        obstaclesList.Add(Obstacle5Destr);
        
        terrainN = 0;

        spawnObstacles(terrainN);
        spawnCoins(terrainN);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            QuitGame();
        }

        if(playerCar.transform.position.z >= 500 + 1000*terrainN )
        {
            terrainN++;
            Instantiate(terrain, new Vector3(-25.0f, 0f, 1000 * terrainN), Quaternion.identity);
            spawnObstacles(terrainN);
            spawnCoins(terrainN);
        }
    }

    void spawnObstacles(float terrainN)
    {
        bool spawnType3 = false;
        int spawnType;


        for (int i = 40; i<=1000; i +=20 )
        {
            float zVal = (float)i;

            // Spawn all across the terrain starting at z = 40
            // 3 random spawns
            if (!spawnType3)
            {
                spawnType = Random.Range(1, 3);
            }
            else 
            {
                spawnType = Random.Range(1, 2);
            }

            if (spawnType == 1)
            {
                spawnType3 = false;
                Instantiate(obstaclesList[Random.Range(0, obstaclesList.Count)], new Vector3(-7.0f, 0.5f, zVal + 1000*terrainN), Quaternion.identity );
                Instantiate(obstaclesList[Random.Range(0, obstaclesList.Count)], new Vector3(0.0f, 0.5f, zVal + 1000 * terrainN), Quaternion.identity);
                // spawns 2 random obstacles at (-7, 0.5, i) and (0, 0.5, i), aka every 20 units
            }
            else if(spawnType == 2)
            {
                spawnType3 = false;
                Instantiate(obstaclesList[Random.Range(0, obstaclesList.Count)], new Vector3(0.0f, 0.5f, zVal + 1000 * terrainN), Quaternion.identity);
                Instantiate(obstaclesList[Random.Range(0, obstaclesList.Count)], new Vector3(7.0f, 0.5f, zVal + 1000 * terrainN), Quaternion.identity);
                // spawns 2 random obstacles at (0, 0.5, i) and (7, 0.5, i), aka every 20 units
            }
            else if (spawnType == 3)
            {
                spawnType3 = true;
                Instantiate(obstaclesList[Random.Range(0, obstaclesList.Count)], new Vector3(-7.0f, 0.5f, zVal + 1000 * terrainN), Quaternion.identity);
                Instantiate(obstaclesList[Random.Range(0, obstaclesList.Count)], new Vector3(7.0f, 0.5f, zVal + 1000 * terrainN), Quaternion.identity);
                // spawns 2 random obstacles at (-7, 0.5, i) and (7, 0.5, i), aka every 20 units
            }
        }
    }

    void spawnCoins(float terrainN)
    {
        for (int i = 30; i <= 1000; i += 20)
        {
            float zVal = (float)i;
            float xVal = Random.Range(-8, 8);
            Instantiate(Coin, new Vector3(xVal, 0.5f, zVal + 1000 * terrainN), Quaternion.identity);
        }
    }

    public void playCoinSound()
    {
        coinSound.Play();
    }


    void QuitGame()
    {
        Application.Quit();
    }
}
