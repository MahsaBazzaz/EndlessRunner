using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] ObstaclePatterns;
    [SerializeField] private float StartTimeBtwSpawn;
    [SerializeField] private float DecreaseTime;
    [SerializeField] private float MinTime = 0.65f;
    private float timeBtwSpawn;
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int randomIndex = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[randomIndex], transform.position, Quaternion.identity);
            timeBtwSpawn = StartTimeBtwSpawn;
            if (StartTimeBtwSpawn > MinTime)
            {
                StartTimeBtwSpawn -= DecreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
