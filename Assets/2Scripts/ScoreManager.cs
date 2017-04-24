using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class ScoreManager : MonoBehaviour {


    private int currScore_int;
    private int prevScore_int;

    public GUIText currScore_GUI;
    public GUIText prevScore_GUI;

    public AudioClip gainMoney;
    public AudioClip loseMoney;

   // public AudioSource AudioSauce;

  

    public void addScore (int newScoreValue)
    {
        currScore_int += newScoreValue;
        prevScore_int += newScoreValue;
    }



    void UpdateCurrScore ()
    {
        currScore_GUI.text = " " + currScore_int;
    }

    void gainMoneyFunction()
    {
       
    }

   /* void loseMoney()
    {

    }
    */

    IEnumerator MoneyControl()
    {
        AudioSource audioSauce = GetComponent<AudioSource>();
        yield return new WaitForSeconds(audioSauce.clip.length);
        audioSauce.clip = gainMoney;
        audioSauce.Play();
    }

    

}
