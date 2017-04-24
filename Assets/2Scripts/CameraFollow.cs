using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    //Take reference of the player.
    //public Transform lookAt;

    //This puts the camera at an offset away from the player.
    private Vector3 offset = new Vector3(0f, 4f, -10f);

    public Transform FollowCamera;
    public Transform Player;

    private void Start()
    {

    }

    //Updated so now the camera follows the player on the X axis only
    private void Update()
    {
        FollowCamera.position = new Vector3(Player.position.x, 0, 0) + offset;
    }

    

}
