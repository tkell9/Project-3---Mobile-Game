using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {


    public GameObject[] mounts;

    private int currStage;

    public Transform FollowCamera;

    public Transform camMount;



    //private ArrayList;



    //Offset of the camera to position it back from the level
    private Vector3 offset = new Vector3(0f, 5.5f, -10f);






    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //Updated so now the camera follows the player on the X axis only
    
        FollowCamera.position = new Vector3(camMount.position.x, 0, 0) + offset;
    
    }
}
