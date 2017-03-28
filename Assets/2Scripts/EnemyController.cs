using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    //Sets target for enemy to move towards, always the player unless decoy is used.
    public Transform target;
    public float move_speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * move_speed);


	}
}
