using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interact
{
    public GameObject light;
    public bool toggle;
    public Renderer lightBuld;
    public Material offLight, onLight;
    public AudioClip lightSwitchSound;
    public Animator switchAnim;


    private void Update()
    {
        if(interactable == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }

        if (toggle)
        {
            light.SetActive(true);
            lightBuld.material = onLight;
        }if (!toggle)
        {
            light.SetActive(false);
            lightBuld.material = offLight;
        }
    }
}
