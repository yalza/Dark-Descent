using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryEventTrigger : MonoBehaviour
{
    public GameObject scare;
    public AudioSource scarySound;
    public Collider collision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scare.SetActive(true);
            collision.enabled = false;
        }
    }
}
