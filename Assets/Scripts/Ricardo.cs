using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Ricardo : MonoBehaviour
{
    public NavMeshAgent AI;
    public Transform Player;
    Vector3 dest;

    private void Update()
    {
        dest = Player.position;
        AI.destination = dest;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Death");
        }
    }
}
