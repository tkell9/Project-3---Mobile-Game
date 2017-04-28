using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private int prefabToShow;
    public GameObject[] buildings;
    public Transform spawnPoint;
    public GameObject trumpIdle;
    public GameObject kanyeIdle;

    private GameObject playOptions;
    public bool tutorialPlayed;




    // Use this for initialization
    void Start()
    {
        playOptions = GameObject.FindGameObjectWithTag("PlayOptions");
        playOptions.gameObject.SetActive(false);
        tutorialComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
    }


    //Switch statement that changes the idle character on the main menu
   

    public void kanye()
    {
        //Will set the menu prefab to kanye and will set the border to active.
        prefabToShow = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void playButton()
    {
        playOptions.gameObject.SetActive(true);
    }

    public void tutorial()
    {
        playOptions.gameObject.SetActive(false);
        SceneManager.LoadScene("TutorialLevel");
        tutorialComplete = true;
    }

    public void play()
    {
        playOptions.gameObject.SetActive(false);
        SceneManager.LoadScene("Level1");
    }

    public void trump()
    {
        //Will set the menu prefab to Trump and will set the border to active.
        prefabToShow = 2;
        SceneManager.LoadScene("MainMenu");
    }

    public void tutorialComplete()
    {
        if (tutorialComplete)
        {

        }
    }
  
    
    //This allows me to place the script on any button and then set
    // the level in the editor. I dont need this function anymore but it will be usefull
    // in future projects.
    // public void LoadLevel(string _SceneName)
    //  {
    //     
    //      SceneManager.LoadScene(_SceneName);
    //  }



    public void exitGame()
    {
        //Exit the game when clicking the exit button.
        Application.Quit();
    }
     
    
    


    /*switch (prefabToShow)
        {
            case 1:
                Instantiate(kanyeIdle, spawnPoint);
                break;

            case 2:
                Instantiate(trumpIdle, spawnPoint);
                break;
        }*/
}
