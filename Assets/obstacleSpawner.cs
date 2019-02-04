﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public Transform obstCube;
    public Transform obstWall;
    public float spawnRandom;
    public float spawnChance;
    public bool spawned;
    void Update()
    {
        spawnRandom = Mathf.Round(Random.Range(0f, 100f));
        if (spawnRandom <= spawnChance)
        {
            Instantiate(obstCube, new Vector3(Random.Range(-5, 5), -0.5f, transform.position.z), Quaternion.identity);
            Destroy(this);
        }
    }
}
