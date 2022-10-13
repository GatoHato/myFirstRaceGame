using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigg;
    public GameObject CheckPointTrigg;

    void OnTriggerEnter()
    {
        LapCompleteTrigg.SetActive(true);
        CheckPointTrigg.SetActive(false);

    }
        
    }

