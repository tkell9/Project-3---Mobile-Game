using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialSlides : MonoBehaviour {


    //public Sprite[] TutorialSlides;
    private Image slide1;
    private Image slide2;
    private Image slide3;
    private Image slide4;
    private Image slide5;
    private Image slide6;
    private Image slide7;
    
    

    private int slideToShow = 0;



	// Use this for initialization
	void Start ()
    {
      

        slide1 = GetComponent<Image>();
        slide1.enabled = false;

        slide2 = GetComponent<Image>();
        slide2.enabled = false;

        slide3 = GetComponent<Image>();
        slide3.enabled = false;

        slide4 = GetComponent<Image>();
        slide4.enabled = false;

        slide5 = GetComponent<Image>();
        slide5.enabled = false;

        slide6 = GetComponent<Image>();
        slide6.enabled = false;

        slide7 = GetComponent<Image>();
        slide7.enabled = false;
 }
	
    void startButton()
    {      
        
    }

    private void Update()
    {
       
        
    }

    



}
