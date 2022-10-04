using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUp : MonoBehaviour
{
    public AudioSource pickupSound;

    public UnityEvent onPickup;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject); //on ne met pas this ici car on veut détruite TOUT le gameObject
            onPickup?.Invoke();
            //pickupSound.Play();

        }
    }
}

//------- Deux méthodes pour jouer le son : -------
// 1) dans le code Audiosource >>> .Play()
// 2) dans le code UnityEvent >>> dans Unity, on ajoute au UnityEvent le Play() avec l'objet Audio Source
