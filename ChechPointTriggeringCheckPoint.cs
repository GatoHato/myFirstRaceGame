using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChechPointTriggeringCheckPoint : MonoBehaviour
{
    public GameObject PrevCheckPointTrigg;
    public GameObject NextCheckPointTrigg;

    void OnTriggerEnter()
    {
        PrevCheckPointTrigg.SetActive(true);
        NextCheckPointTrigg.SetActive(false);

    }
}
