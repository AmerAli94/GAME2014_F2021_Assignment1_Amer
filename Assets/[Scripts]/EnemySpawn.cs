// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added Enemy Spawns and File Headers for the project
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    float randPosition;
    Vector2 spawnPosition;
    public float spawnRate = 2.0f;
    private float nextSpawn = 0.0f;

    public List<GameObject> enemyList;
    private GameObject randEnemy;
    

    private GameObject RandomEnemy()
    {
        var randTemp = Random.Range(0, enemyList.Count);

        for(int i = 0; i < enemyList.Count; i++)
        {
            if(i == randTemp)
            {
                randEnemy = enemyList[i];
            }
        }

        return randEnemy;
    }

    private void SpawnEnemy()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randPosition = Random.Range(-2.4f, 2.4f);
            spawnPosition = new Vector2(randPosition, transform.position.y);
            Instantiate(RandomEnemy(), spawnPosition, Quaternion.identity, this.transform);
        }
    }


    private void Update()
    {
        SpawnEnemy();
    }
}
