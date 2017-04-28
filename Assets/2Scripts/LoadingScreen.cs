using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour {

    public Texture2D controllerScreen;
    static LoadingScreen instance1;


    private void Awake()
    {
        if (instance1)
        {
            Destroy(gameObject);
          //  hide();
            return;
        }
        instance1 = this;
        gameObject.AddComponent<GUITexture>().enabled = false;
       // GetComponent<Texture2D>().controllerScreen = controllerScreen;
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
