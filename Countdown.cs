
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{

    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject BMWE30;
    public GameObject TouringCar;
    public GameObject SubaruWRX;

    void Start()
    {
        StartCoroutine(CountStart());
        BMWE30.GetComponent<VehiclePhysics.VPStandardInput>().enabled = false;
        TouringCar.GetComponent<VehiclePhysics.VPStandardInput>().enabled = false;
        SubaruWRX.GetComponent<VehiclePhysics.VPStandardInput>().enabled = false;
    }

    IEnumerator CountStart ()
    {

        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);
        BMWE30.GetComponent<VehiclePhysics.VPStandardInput>().enabled = true;
        TouringCar.GetComponent<VehiclePhysics.VPStandardInput>().enabled = true;
        SubaruWRX.GetComponent<VehiclePhysics.VPStandardInput>().enabled = true;
    }


}