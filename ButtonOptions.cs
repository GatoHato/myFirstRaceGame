using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    public GameObject ScoreModeTrackSelection;
    public GameObject TimeAttackTrackSelection;
    public int RaceMode;

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void TrackSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Butons note
    public void Track01()
    {
        SceneManager.LoadScene(1);
    }
    public void Track02()
    {
        SceneManager.LoadScene(2);
    }
    public void Track03()
    { 
        SceneManager.LoadScene(3);
        }
    void Update()
    {
        if (RaceMode == 1)
        {
            ScoreModeTrackSelection.SetActive(true);
            TimeAttackTrackSelection.SetActive(false);
        }
        if (RaceMode == 2)
        {
            ScoreModeTrackSelection.SetActive(false);
            TimeAttackTrackSelection.SetActive(true);
        }
    }
}
