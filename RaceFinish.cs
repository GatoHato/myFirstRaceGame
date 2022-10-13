using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaceFinish : MonoBehaviour
{

    public GameObject FinishCam;
    public GameObject ViewMode1;
    public GameObject ViewMode2;
    public GameObject ViewMode3;
    public GameObject LevelMusic;
    public GameObject CompleteTrigg;
    public AudioSource FinishMusic;
    public GameObject VehicleBrakes;
    public GameObject Dashboard1;
    public GameObject Dashboard2;
    public GameObject Dashboard3;

    void OnTriggerEnter()
    {
        if (ModeTime.isTimeMode == true)
        {
            //we are on race TIME mode
        }
        else
        {
            Dashboard1.SetActive(false);
            Dashboard2.SetActive(false);
            Dashboard3.SetActive(false);
            CompleteTrigg.SetActive(false);
    
        FinishCam.SetActive(true);
        LevelMusic.SetActive(false);
        ViewMode1.SetActive(false);
            ViewMode2.SetActive(false);
            ViewMode3.SetActive(false);
            FinishMusic.Play();
            GlobalCash.TotalCash += 1000;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
        }
       


    }
}
