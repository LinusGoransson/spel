﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner4 : MonoBehaviour {
    public GameObject fiende4;
    //sekunder mellan när fiender spawnar
    public float spawnRäknare = 1;
    float nextSpawnTime;

    Vector2 screenHalf;

    // Use this for initialization
    void Start()
    {
        //Räknar ut möjliga platser där fiender kan spawna
        screenHalf = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        //ifall spel tiden är större än 16 sekunder kommer fiender från level 4
        if (Time.timeSinceLevelLoad > 16)
        {
            //ifall den nuvarande speltiden i spelet är större än nexrSpawnTime spawnas fiender.
            if (Time.timeSinceLevelLoad > nextSpawnTime)
            {
                nextSpawnTime = Time.timeSinceLevelLoad + spawnRäknare;
                Vector2 spawnPosition = new Vector2(Random.Range(-screenHalf.x, screenHalf.x), screenHalf.y + .10f);
                Instantiate(fiende4, spawnPosition, Quaternion.identity);

            }
        }
    }
}
