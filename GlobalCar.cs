using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalCar : MonoBehaviour
{
  public static int CarType; //1=BMW 2=Touring 3=Subaru
        public GameObject TrackWindow;
    public GameObject CarWindow;

  public void BMWE30 ()
   {
        CarType = 1;
        TrackWindow.SetActive(true);
        CarWindow.SetActive(false);


   }
    public void TouringCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
        CarWindow.SetActive(false);
    }
    public void SubaruWRX()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
        CarWindow.SetActive(false);
    }
}
