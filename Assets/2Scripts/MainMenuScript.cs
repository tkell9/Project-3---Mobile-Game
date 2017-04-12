using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

  //  int levelToLoad;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		

	}

    public void LoadLevel(string _SceneName)
    {
        SceneManager.LoadScene(_SceneName);
    }
}
