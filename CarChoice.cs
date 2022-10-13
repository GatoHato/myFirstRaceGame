using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject BMWE30;         //1
    public GameObject TouringCar;     //2
    public GameObject SubaruWRX;      //3
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            BMWE30.SetActive(true);
            TouringCar.SetActive(false);
            SubaruWRX.SetActive(false);
        }
        if (CarImport == 2)
        {
            TouringCar.SetActive(true);
            BMWE30.SetActive(false);
            SubaruWRX.SetActive(false);
        }
        if (CarImport == 3)
        {
            SubaruWRX.SetActive(true);
            TouringCar.SetActive(false);
            BMWE30.SetActive(false);
        }
    }


}
