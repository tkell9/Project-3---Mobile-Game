using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {




    public float moveSpeed = 100f;

    //public float lifeTime;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
