using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour
{
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreObjects;
    public GameObject WinScoreFinishCam;
    public AudioSource LevelMusic;
    public GameObject GameCamera1;
    public GameObject GameCamera2;
    public GameObject GameCamera3;
    public GameObject LoseScoreFinishCam;
    public static int CarChoice;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;
        CurrentScore = 0;
        if (ModeSelection == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObjects.SetActive(true);
            
        }
        if (CarChoice == 1)
        {
            GameCamera1.SetActive(true);
            GameCamera2.SetActive(false);
            GameCamera3.SetActive(false);
        }
        if (CarChoice == 2)
        {
            GameCamera1.SetActive(false);
            GameCamera2.SetActive(true);
            GameCamera3.SetActive(false);
        
        }
        if (CarChoice ==3)
        {
            GameCamera1.SetActive(false);
            GameCamera2.SetActive(false);
            GameCamera3.SetActive(true);
        }
    }


    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;


        if (CurrentScore >= 3500)
        {
            WinScoreFinishCam.SetActive(true);
            LoseScoreFinishCam.SetActive(false);
            GameCamera1.SetActive(false);
            GameCamera2.SetActive(false);
            GameCamera3.SetActive(false);
            GlobalCash.TotalCash += 1000;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        }
    }
}
