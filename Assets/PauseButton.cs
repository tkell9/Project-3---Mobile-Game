using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {


    private Sprite pauseMenu;

	// Use this for initialization
	void Start ()
    {
        pauseMenu = GetComponent<Sprite>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pauseGame()
    {
        Time.timeScale = 0;
        GetComponent<pauseMenu>.enabled = true;
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
    }
}
