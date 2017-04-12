using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {


    int enemyToSpawn;

    float spawnDelay = 3f;

    public Transform enemyPrefab;

    int index;


	// Use this for initialization
	void Start () {
        {
            Instantiate(enemyPrefab) ;
        }

	}
	
	// Update is called once per frame
	void Update () {
       



    }
}
