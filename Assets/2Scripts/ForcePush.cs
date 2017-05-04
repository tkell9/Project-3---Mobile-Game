using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForcePush : MonoBehaviour {

    public Transform playerLocation;
    public GameObject speechBubble;

    public float delay = 7f;
    public float delaySkip = 1f;

    private bool isActivated = false;
    private bool isReady = true;

    public Slider delayCounter;

    public static int moveSpeed = 3;
    public Vector3 direction = Vector3.right;

    public float fakeTime;
    







    public void activateSpeech()
    {
        if (fakeTime * delaySkip >= delay)
        {
            isReady = true;
        }
        else
        {
            isReady = false;
        }
    }



	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        fakeTime = Time.fixedDeltaTime;
        
	}

    public void forcePush()
    {
        if(isReady)
        {
            Instantiate(speechBubble, new Vector3(-39,3,0),Quaternion.Euler(0,-90,0));
            isReady = false;
            
        }
        else
        {
            return;
        }
    }
}
