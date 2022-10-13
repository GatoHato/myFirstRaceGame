using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePickUpTrigger : MonoBehaviour
{
    public AudioSource CubePickupSound;

  void OnTriggerEnter(Collider other)
    {
        CubePickupSound.Play();
    }

}
