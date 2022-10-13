using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource audioSource;
    public ParticleSystem ParticleSplash1;
    public ParticleSystem ParticleSplash2;
    public ParticleSystem ParticleSplash3;
    public ParticleSystem ParticleSplash4;
    public ParticleSystem ParticleSplash5;

       

    void OnTriggerEnter(Collider other)
    {
        
      audioSource.Play();

        ParticleSplash1.Play();
        ParticleSplash2.Play();
        ParticleSplash3.Play();

        ParticleSplash4.Play();
        ParticleSplash5.Play();



    }


}
