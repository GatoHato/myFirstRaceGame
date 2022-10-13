using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour
{
    public int ModeSelection;

    public GameObject AICar;
    public GameObject GameCamera1;
    public GameObject GameCamera2;
    public GameObject GameCamera3;
    public static int CarChoice;
    public static int LapsDone;
 

    public static bool isTimeMode = false;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if (ModeSelection == 2)
        {


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
            if (CarChoice == 3)
            {
                GameCamera1.SetActive(false);
                GameCamera2.SetActive(false);
                GameCamera3.SetActive(true);
            }

        }

    }
 
}



