using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCamera : MonoBehaviour {

    //This script used to be for moving the camera along fixed points in world space.
    //The camera would lerp between the points to create a smooth transition.
    //
    //This script is no longer needed for the final game.
    //
    //Attach this script to the camera and assign the start and end points. 

    public Transform startPoint;
    public Transform endPoint;
    public float speed = 1.5f;

    private float distanceCovered;
    private float fragJourney;
    private float startTime;
    private float transitionLength;


	// Use this for initialization
	void Start ()
    {
        startTime = Time.time;
        transitionLength = Vector3.Distance(startPoint.position, endPoint.position);

	}
	
	// Update is called once per frame
	void Update ()
    {
        distanceCovered = (Time.time - startTime) * speed;
        fragJourney = distanceCovered / transitionLength;
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, fragJourney);
	}
}
