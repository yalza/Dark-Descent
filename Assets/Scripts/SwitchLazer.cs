using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLazer : Interact
{
    public GameObject Lazes;

    public bool toggle;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            toggle = !toggle;
            if (toggle)
            {
                anim.ResetTrigger("Off");
                anim.SetTrigger("On");
                Lazes.SetActive(true);
            }
            else
            {
                anim.ResetTrigger("On");
                anim.SetTrigger("Off");
                Lazes.SetActive(false); 
            }
            intText.SetActive(false);
            interactable = false;
        }
    }
}
