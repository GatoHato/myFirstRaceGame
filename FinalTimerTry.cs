using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTimerTry : MonoBehaviour
{
    public float timeValue = 90;
    public Text timerText;
    public GameObject WinScoreFinishCam;
    public GameObject LoseScoreFinishCam;
    public GameObject LevelMusic;
    public GameObject GameCamera1;
    public GameObject GameCamera2;
    public GameObject GameCamera3;
    public AudioSource FinishMusic;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
   

   
 
    //Update is called once per frame
    void Update()
    {
        
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        if (timeValue == 0)
        {
           
            LoseScoreFinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            GameCamera1.SetActive(false);
            GameCamera2.SetActive(false);
            GameCamera3.SetActive(false);
            FinishMusic.Play();
            GlobalCash.TotalCash += 100;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        }


        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = timeToDisplay % 1 * 1000;

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);

    }
}