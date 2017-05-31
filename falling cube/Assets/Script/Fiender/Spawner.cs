using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject fiende, fiende2, fiende3, fiende4;
    //sekunder mellan när fiender spawnar
    public float spawnRäknare = 1;
    float nextSpawnTime;

    Vector2 screenHalf;

	// Use this for initialization
	void Start () {
        //Räknar ut möjliga platser där fiender kan spawna
        screenHalf = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
	}

	void spawnfiende1(){
		nextSpawnTime = Time.timeSinceLevelLoad + spawnRäknare;
		Vector2 spawnPosition = new Vector2 (Random.Range (-screenHalf.x, screenHalf.x), screenHalf.y + .10f);
		Instantiate (fiende, spawnPosition, Quaternion.identity);
	}

	void spawnfiende2(){
		nextSpawnTime = Time.timeSinceLevelLoad + spawnRäknare;
		Vector2 spawnPosition2 = new Vector2(Random.Range(-screenHalf.x, screenHalf.x), screenHalf.y + .10f);
		Instantiate(fiende2, spawnPosition2, Quaternion.identity);
	}

	void spawnfiende3(){
		nextSpawnTime = Time.timeSinceLevelLoad + spawnRäknare;
		Vector2 spawnPosition3 = new Vector2(Random.Range(-screenHalf.x, screenHalf.x), screenHalf.y + .10f);
		Instantiate(fiende3, spawnPosition3, Quaternion.identity);
	}

	void spawnfiende4(){
		nextSpawnTime = Time.timeSinceLevelLoad + spawnRäknare;
		Vector2 spawnPosition4 = new Vector2(Random.Range(-screenHalf.x, screenHalf.x), screenHalf.y + .10f);
		Instantiate(fiende4, spawnPosition4, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        //ifall spel tiden är mindre eller lika med 8 sekunder kommer fiender från level 1
		if (Time.timeSinceLevelLoad <= 8) {
			//ifall den nuvarande speltiden i spelet är större än nexrSpawnTime spawnas fiender.
			if (Time.timeSinceLevelLoad > nextSpawnTime) {
				spawnfiende1 ();
			}
		}
		//ifall spel tiden är mindre eller lika med 12 sekunder kommer fiender från level 2
		else if (Time.timeSinceLevelLoad <= 12) {
			if (Time.timeSinceLevelLoad > nextSpawnTime) {
				spawnfiende1 ();
				spawnfiende2 ();
			}
		}
		//ifall spel tiden är mindre eller lika med 12 sekunder kommer fiender från level 2
		else if (Time.timeSinceLevelLoad <= 20) {
			if (Time.timeSinceLevelLoad > nextSpawnTime) {
				spawnfiende1 ();
				spawnfiende2 ();
				spawnfiende3 ();
			}
		} else {
			if (Time.timeSinceLevelLoad > nextSpawnTime) {
				spawnfiende1 ();
				spawnfiende2 ();
				spawnfiende3 ();
				spawnfiende4 ();
			}
		}


    }
}
