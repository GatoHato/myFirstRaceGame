using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactParticles : MonoBehaviour
{
    public GameObject FR;

  void Start()
    {
    

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider metalfence) 
    {

        FR.SetActive(true);

    }
    void OnTriggerExit(Collider other)
    {
        FR.SetActive(false);
    }
}
