using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraMove : MonoBehaviour {


    public GameObject[] mounts;

    //private int currStage;

    public Transform camMount;

    public float cameraMoveSpeed = 1.0f;

    private float time = 0;

   // private Transform camNewPosition;

    public Transform targetMount;

    public Camera MainCamera;

    public Transform camTargetPosition;

    public Transform camCurrentPosition;

    public Transform[] camNextPosition;

    private bool camera_change_mount = false;

    public AnimationCurve cameraCurve = AnimationCurve.EaseInOut(0,0,1,1);

    private int currentStage = 1;

  

    //private ArrayList;



    //Offset of the camera to position it back from the level
    private Vector3 offset = new Vector3(0f, 5.5f, -10f);


    void moveCamera()
    {
        while (time < 1.0f)
        {
            time += Time.deltaTime * (Time.timeScale / cameraMoveSpeed);
        }
    }


    void updateCurrentStage(int newStage)
    {
        
    }


   /* void setCameraPositon()
    {
        MainCamera.transform.position = camCurrentPosition;
    } 
   */

    // void OnTriggerEnter(Collider stage)
    //  {
    //      camPosition = targetMount;
    //  }

    void stageTransition()
    {
        if (camera_change_mount)
        {
            MainCamera.transform.position = Vector3.Lerp(transform.position, camTargetPosition.transform.position, cameraMoveSpeed * Time.deltaTime);
            //MainCamera.transform.position = Quaternion.Lerp(transform.rotation, targetMount.transform.rotation, cameraMoveSpeed * Time.deltaTime);

        }
    }

    public void onClick()
    {
        if (camera_change_mount == false)
        {
          camera_change_mount = true;
            //MainCamera.transform.position = camTargetPosition.position;
            //MainCamera.transform.position = Vector3.Lerp(MainCamera.transform.position, camTargetPosition.transform.position, cameraMoveSpeed * Time.deltaTime);
            StartCoroutine(LerpCamera(Time.time));
            currentStage++;
        }

    }

    IEnumerator LerpCamera(float startTime)
    {
        while (MainCamera.transform.position != camTargetPosition.position)
        {
            MainCamera.transform.position = Vector3.Lerp(camCurrentPosition.position, camTargetPosition.position, cameraCurve.Evaluate(cameraMoveSpeed * (Time.time - startTime)));
            yield return new WaitForFixedUpdate();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    //Updated so now the camera follows the player on the X axis only
    
        //FollowCamera.position = new Vector3(camMount.position.x, 0, 0) + offset;
    
    }
}
