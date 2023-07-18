using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interact
{
    public GameObject Key,LockedText;
    public bool toggle;
    public Animator doorAnim;
    public AudioSource openDoorSound, closeDoorSound;

    private void Update()
    {
        if(interactable)
        {
            if(Input.GetKeyUp(KeyCode.E)) {
                if(Key.active == false)
                {
                    toggle = !toggle;
                    if (toggle)
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
                    interactable = false;
                }
                else
                {
                    LockedText.SetActive(true);
                    StopCoroutine(disableText());
                    StartCoroutine(disableText());
                }
            }
        }
    }

    IEnumerator disableText()
    {
        yield return new WaitForSeconds(2f);
        LockedText.SetActive(false);
    }
}
