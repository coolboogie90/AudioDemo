using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapshotSwitch : MonoBehaviour
{
    
    public AudioMixerSnapshot snapshot1, snapshot2;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            snapshot1.TransitionTo(3f);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            snapshot2.TransitionTo(3f);
        }
    }

}
