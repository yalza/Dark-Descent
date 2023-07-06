using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public GameObject intText, Key;
    public AudioSource pickupSound;
    public bool interactable;

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

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false) ;
            interactable = false;
        }
    }
}
