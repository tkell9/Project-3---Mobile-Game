using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    //Sets target for enemy to move towards, always the player unless decoy is used.
    //public Transform target;
    //public float move_speed;

    private int levelOfDifficulty;
    private int enemyToSpawn;
    private bool isBoss;
    private int randomNumber;
    private int modifierNumber;

	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * move_speed);




	}
}
