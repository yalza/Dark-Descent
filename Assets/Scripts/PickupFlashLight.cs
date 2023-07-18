using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFlashLight : Interact
{
    public GameObject flashLightTable, flashLightHand;
    public AudioSource pickupSound;

    private void Update()
    {
        if(interactable)
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                intText.SetActive(false);
                interactable= false;
                flashLightHand.SetActive(true);
                flashLightTable.SetActive(false);
            }
        }
    }

   
}
