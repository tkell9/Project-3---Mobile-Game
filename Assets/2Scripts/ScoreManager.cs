using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {


    private int currScore_int;
    private int prevScore_int;

    public GUIText currScore_GUI;
    public GUIText prevScore_GUI;


    private void Start()
    {
        currScore_int = 0;
    }

    public void addScore (int newScoreValue)
    {
        currScore_int += newScoreValue;
        prevScore_int += newScoreValue;
    }



    void UpdateCurrScore ()
    {
        currScore_GUI.text = " " + currScore_int;
    }





}
