using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour {

    public int enemyToSpawn; //1=basic, 2=tank, 3=spider, 4=boss
    private bool enemyReady; //If any is ready it means there is already an enemy that has spawned for combat. 

    public GameObject enemyPrefabNormal;
    public GameObject enemyPrefabTank;
    public GameObject enemyPrefabSpider;
    public GameObject enemyPrefabBoss;

    //public GameObject enemyPrefab;
    public GameObject enemySpawnPoint;

    //private int index1;
    public int randomNumber;


    void Start ()
    {
	}
	
	
	void Update ()
    {
        if (enemyReady == false)
        {
            randomNumberGen();

            enemyReady = true;
        }
	}

    void randomNumberGen()
    {
        randomNumber = (Random.Range(0, 100));	
    }

    void whatEnemyToSpawn()
    {
        if(randomNumber<=55)
        {
            enemyToSpawn = 1;
            Instantiate(enemyPrefabNormal, new Vector3(-32f,9.7f,0.3f),(Quaternion.identity));
        }
        else if(randomNumber>55 && randomNumber<=80)
        {
            enemyToSpawn = 2;
        }
        else if(randomNumber>80 && randomNumber<=95)
        {
            enemyToSpawn = 3;
        }
        else
        {
            enemyToSpawn = 4;
        }
    }
}

