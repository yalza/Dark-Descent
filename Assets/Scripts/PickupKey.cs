using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : Interact
{
    public GameObject Key;
    public AudioSource pickupSound;

    private void Update()
    {
        if(interactable)
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                intText.SetActive(false);
                interactable= false;
                Key.SetActive(false);
            }
        }
    }
}
