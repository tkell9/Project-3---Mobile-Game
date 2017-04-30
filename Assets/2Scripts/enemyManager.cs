using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour {

    private int enemyToSpawn;
    private bool enemyReady; //If any is ready it means there is already an enemy that has spawned for combat. 

    public Transform enemyPrefabNormal;
    public Transform enemyPrefabTank;
    public Transform enemyPrefabSpider;
    public Transform enemyPrefabBoss;

    public GameObject enemySpawnPoint;

    private int index1;
    private int randomNumber;


    void Start ()
    {
    
		
	}
	
	
	void Update ()
    {
		
	}
}
