using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanBob : MonoBehaviour
{
    public Animator cameraAnim;
    public bool walking;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.S))
        {
            walking = true;
            cameraAnim.ResetTrigger("idle");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("walk");

            if(walking == true)
            {
                if(Input.GetKey(KeyCode.LeftShift))
                {
                    cameraAnim.ResetTrigger("idle");
                    cameraAnim.ResetTrigger("walk");
                    cameraAnim.SetTrigger("sprint");
                }
            }
        }
        else
        {
            cameraAnim.ResetTrigger("walk");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("idle");
            walking = false;
        }

    }
}
