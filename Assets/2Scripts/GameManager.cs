using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    //public int pauseMenuID = 0;

    private GameObject pausePanel;

    private GameObject exitConfirm;

    static bool active = false;


    // Use this for initialization
    void Start()
    {
        pausePanel = GameObject.FindGameObjectWithTag("PauseMenu");
        exitConfirm = GameObject.FindGameObjectWithTag("ExitConfirm");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void enablePauseMenu(int pauseMenuID)
    {
        
    }


    public void pauseGame()
    {
        Time.timeScale = 0;
       // pauseMenuID = 1;
        pausePanel.gameObject.SetActive(true);
        
    }


    public void resumeGame()
    {
        //what to do when pause button is pressed
        Time.timeScale = 1;
        pausePanel.gameObject.SetActive(false);
        // pauseMenuID = 2;
    }

    public void exitGame()
    {
        exitConfirm.gameObject.SetActive(true);
        pausePanel.gameObject.SetActive(false);
    }

    public void exitApplication()
    {
        exitConfirm.gameObject.SetActive(false);
        SceneManager.LoadScene("MainMenu");

    }
}
