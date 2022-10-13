using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControll : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject CarControl2;

    void Start()
    {
        CarControl.GetComponent<CarControll>().enabled = true;
        CarControl2.GetComponent<CarControll>().enabled = true;

    }
}

