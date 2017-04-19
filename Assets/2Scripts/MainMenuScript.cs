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


    // Use this for initialization
    void Start()
    {
          switch (prefabToShow)
        {
            case 1:
                Instantiate(kanyeIdle, spawnPoint);
                break;

            case 2:
                Instantiate(trumpIdle, spawnPoint);
                break;
        }

    
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

    public void trump()
    {
        //Will set the menu prefab to Trump and will set the border to active.
        prefabToShow = 2;
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadLevel(string _SceneName)
    {
        //This allows me to place the script on any button and then set
        //the level in the editor.
        SceneManager.LoadScene(_SceneName);
    }

    public void exitGame()
    {
        //Exit the game when clicking the exit button.
        Application.Quit();
    }
}
