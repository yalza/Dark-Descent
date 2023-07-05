using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject intText;
    public bool toggle, interactale;
    public Animator doorAnim;
    public AudioSource openDoorSound, closeDoorSound;

    private void Update()
    {
        if(interactale)
        {
            if(Input.GetKeyUp(KeyCode.E)) {
                toggle = !toggle;
                if(toggle)
                {
                    doorAnim.ResetTrigger("close");
                    doorAnim.SetTrigger("open");
                }
                if (!toggle)
                {
                    doorAnim.ResetTrigger("open");
                    doorAnim.SetTrigger("close");
                }
                intText.SetActive(false);
                interactale = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactale = true;
            intText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactale = false;
            intText.SetActive(false);
        }
    }
}
